using System.Text;

namespace Doxygen2HugoConverter
{
    internal static class HeaderUtils
    {
        public static IDictionary<String, String> ParseData(String source)
        {
            IDictionary<String, String> data = new Dictionary<String, String>();
            foreach (String line in source.Split('\n'))
            {
                Int32 colonIndex = line.IndexOf(':');
                if (colonIndex != -1)
                {
                    String key = line.Substring(0, colonIndex).Trim();
                    String value = line.Substring(colonIndex + 1).Trim();
                    data.Add(key, value);
                }
            }

            return data;
        }
    }

    internal static class HeaderTemplateFactory
    {
        public static Func<IDictionary<String, String>, String> CreateFromSource(String source)
        {
            StringBuilder dest = new StringBuilder();
            IList<String> parameters = new List<String>();
            State ProcessChar(State state, Char ch)
            {
                switch (state)
                {
                    case UsualTextState _ when ch == Eof:
                        return state;
                    case UsualTextState _ when ch == '$':
                        return new ParameterState();
                    case UsualTextState _:
                        dest.Append(ch);
                        return state;
                    case ParameterState parameterState when ch == Eof:
                        dest.Append($"{{{parameters.Count}}}");
                        parameters.Add(parameterState.Name.ToString());
                        return state;
                    case ParameterState parameterState when ch == '$':
                        dest.Append($"{{{parameters.Count}}}");
                        parameters.Add(parameterState.Name.ToString());
                        return new ParameterState();
                    case ParameterState parameterState when !Char.IsLetter(ch):
                        dest.Append($"{{{parameters.Count}}}");
                        parameters.Add(parameterState.Name.ToString());
                        dest.Append(ch);
                        return new UsualTextState();
                    case ParameterState parameterState:
                        parameterState.Name.Append(ch);
                        return state;
                    default:
                        throw new InvalidOperationException("Bad state");
                }
            }
            State state = new UsualTextState();
            foreach (Char ch in source)
                state = ProcessChar(state, ch);
            ProcessChar(state, Eof);
            String template = dest.ToString();
            String GetResult(IDictionary<String, String> data)
            {
                const String descriptionKey = "description";
                Object[] args = new Object[parameters.Count];
                for (Int32 index = 0; index < parameters.Count; ++index)
                {
                    if (!data.ContainsKey(parameters[index]))
                        throw new InvalidOperationException("Bad data");
                    args[index] = parameters[index] switch
                    {
                        descriptionKey => data[parameters[index]].Replace("'", "''"),
                        _ => data[parameters[index]]
                    };
                }
                return String.Format(template, args);
            }
            return GetResult;
        }

        private abstract record State;

        private record UsualTextState : State;

        private record ParameterState : State
        {
            public StringBuilder Name { get; } = new();
        }

        private const Char Eof = '\u0000';
    }
}

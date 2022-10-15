module GeneratorUtils

let GenerateChildUrl (folderName: string) = sprintf $"./{folderName}/"

let GenerateLink (name: string) (url: string) = $"[{name}]({url})"
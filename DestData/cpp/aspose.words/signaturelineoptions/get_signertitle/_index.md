---
title: Aspose::Words::SignatureLineOptions::get_SignerTitle method
linktitle: get_SignerTitle
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::SignatureLineOptions::get_SignerTitle method. Gets or sets suggested signer's title. Default value for this property is empty string in C++.
type: docs
weight: 92
url: /cpp/aspose.words/signaturelineoptions/get_signertitle/
---
## SignatureLineOptions::get_SignerTitle method


Gets or sets suggested signer's title. Default value for this property is **empty string**.

```cpp
System::String Aspose::Words::SignatureLineOptions::get_SignerTitle() const
```


## Examples



Shows how to add a signature line to a document, and then sign it using a digital certificate. 
```cpp
static void Sign()
{
    String signeeName = u"Ron Williams";
    String srcDocumentPath = MyDir + u"Document.docx";
    String dstDocumentPath = ArtifactsDir + u"SignDocumentCustom.Sign.docx";
    String certificatePath = MyDir + u"morzal.pfx";
    String certificatePassword = u"aw";

    CreateSignees();

    auto signeeInfo = mSignees->Find(System::Predicate<SharedPtr<Signee>>([&](SharedPtr<Signee> c) { return c->get_Name() == signeeName; }));

    if (signeeInfo != nullptr)
    {
        SignDocument(srcDocumentPath, dstDocumentPath, signeeInfo, certificatePath, certificatePassword);
    }
    else
    {
        FAIL() << "Signee does not exist.";
    }
}

class Signee : public System::Object
{
public:
    System::Guid get_PersonId()
    {
        return pr_PersonId;
    }

    void set_PersonId(System::Guid value)
    {
        pr_PersonId = value;
    }

    String get_Name()
    {
        return pr_Name;
    }

    void set_Name(String value)
    {
        pr_Name = value;
    }

    String get_Position()
    {
        return pr_Position;
    }

    void set_Position(String value)
    {
        pr_Position = value;
    }

    ArrayPtr<uint8_t> get_Image()
    {
        return pr_Image;
    }

    void set_Image(ArrayPtr<uint8_t> value)
    {
        pr_Image = value;
    }

    Signee(System::Guid guid, String name, String position, ArrayPtr<uint8_t> image)
    {
        set_PersonId(guid);
        set_Name(name);
        set_Position(position);
        set_Image(image);
    }

private:
    System::Guid pr_PersonId;
    String pr_Name;
    String pr_Position;
    ArrayPtr<uint8_t> pr_Image;
};
static void SignDocument(String srcDocumentPath, String dstDocumentPath, SharedPtr<ExSignDocumentCustom::Signee> signeeInfo, String certificatePath,
                         String certificatePassword)
{
    auto document = MakeObject<Document>(srcDocumentPath);
    auto builder = MakeObject<DocumentBuilder>(document);

    // Configure and insert a signature line, an object in the document that will display a signature that we sign it with.
    auto signatureLineOptions = MakeObject<SignatureLineOptions>();
    signatureLineOptions->set_Signer(signeeInfo->get_Name());
    signatureLineOptions->set_SignerTitle(signeeInfo->get_Position());

    SharedPtr<SignatureLine> signatureLine = builder->InsertSignatureLine(signatureLineOptions)->get_SignatureLine();
    signatureLine->set_Id(signeeInfo->get_PersonId());

    // First, we will save an unsigned version of our document.
    builder->get_Document()->Save(dstDocumentPath);

    SharedPtr<CertificateHolder> certificateHolder = CertificateHolder::Create(certificatePath, certificatePassword);

    auto signOptions = MakeObject<SignOptions>();
    signOptions->set_SignatureLineId(signeeInfo->get_PersonId());
    signOptions->set_SignatureLineImage(signeeInfo->get_Image());

    // Overwrite the unsigned document we saved above with a version signed using the certificate.
    DigitalSignatureUtil::Sign(dstDocumentPath, dstDocumentPath, certificateHolder, signOptions);
}

static ArrayPtr<uint8_t> ImageToByteArray(SharedPtr<System::Drawing::Image> imageIn)
{
    {
        auto ms = MakeObject<System::IO::MemoryStream>();
        imageIn->Save(ms, System::Drawing::Imaging::ImageFormat::get_Png());
        return ms->ToArray();
    }
}

static void CreateSignees()
{
    mSignees = MakeObject<System::Collections::Generic::List<SharedPtr<ExSignDocumentCustom::Signee>>>();
    mSignees->Add(MakeObject<ExSignDocumentCustom::Signee>(System::Guid::NewGuid(), u"Ron Williams", u"Chief Executive Officer",
                                                           ImageToByteArray(System::Drawing::Image::FromFile(ImageDir + u"Logo.jpg"))));
    mSignees->Add(MakeObject<ExSignDocumentCustom::Signee>(System::Guid::NewGuid(), u"Stephen Morse", u"Head of Compliance",
                                                           ImageToByteArray(System::Drawing::Image::FromFile(ImageDir + u"Logo.jpg"))));
}

static SharedPtr<System::Collections::Generic::List<SharedPtr<ExSignDocumentCustom::Signee>>> mSignees;
```

## See Also

* Class [SignatureLineOptions](../)
* Namespace [Aspose::Words](../../)
* Library [Aspose.Words for C++](../../../)

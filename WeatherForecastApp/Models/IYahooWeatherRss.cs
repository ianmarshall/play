
public interface Irss
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("channel", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    IrssChannel[] channel { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    string version { get; set; }
}

public interface IrssChannel
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    string title { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    string link { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    string description { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    string language { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    string lastBuildDate { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    string ttl { get; set; }

    /// <remarks/>
    Ilocation location { get; set; }

    /// <remarks/>
    Iunits units { get; set; }

    /// <remarks/>
    Iwind wind { get; set; }
}

public interface Ilocation
{
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    string city { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    string region { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    string country { get; set; }
}

public interface Iunits
{
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    string temperature { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    string distance { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    string pressure { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    string speed { get; set; }
}

public interface Iwind
{
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    string chill { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    string direction { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    string speed { get; set; }
}
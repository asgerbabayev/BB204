using System.Xml.Serialization;

[XmlRoot(ElementName = "Valute")]
public class Valute
{

    [XmlAttribute(AttributeName = "Code")]
    public string Code { get; set; }

    [XmlText]
    public string Text { get; set; }
}

[XmlRoot(ElementName = "ValType")]
public class ValType
{

    [XmlElement(ElementName = "Valute")]
    public List<Valute> Valute { get; set; }

    [XmlAttribute(AttributeName = "Type")]
    public string Type { get; set; }

    [XmlText]
    public string Text { get; set; }
}

[XmlRoot(ElementName = "ValCurs")]
public class ValCurs
{

    [XmlElement(ElementName = "ValType")]
    public List<ValType> ValType { get; set; }

    [XmlAttribute(AttributeName = "Date")]
    public string Date { get; set; }

    [XmlAttribute(AttributeName = "Name")]
    public string Name { get; set; }

    [XmlAttribute(AttributeName = "Description")]
    public string Description { get; set; }

    [XmlText]
    public string Text { get; set; }
}


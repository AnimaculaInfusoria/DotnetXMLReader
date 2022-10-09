using System;
using System.Xml;

namespace ReadXMLFile
{
    class Class1
    {
        static void Main(string[] args)
        {
            String FilePath = "fkin_path";
            XmlTextReader reader = new XmlTextReader (FilePath);

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        Console.Write(reader.Name.ToUpper() + "\n");

                        while (reader.MoveToNextAttribute())
                            Console.WriteLine(reader.Name + reader.Value);
                        
                        break;
                    case XmlNodeType.Text:
                        Console.WriteLine (reader.Value);
                        break;
                    
                }
            }
        }
    }
}
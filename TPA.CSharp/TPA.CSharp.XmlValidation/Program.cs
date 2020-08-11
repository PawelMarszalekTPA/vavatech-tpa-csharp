using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Schema;
using TPA.CSharp.XmlValidation.Models;

namespace TPA.CSharp.XmlValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("XML Validator!");

            CsvObrotowkaService obrotowkaService = new CsvObrotowkaService();
            IEnumerable<Account> accounts = obrotowkaService.Get("Obrotówka.csv");

            // TODO: zapis do xml

            XmlObrotowkaService xmlObrotowkaService = new XmlObrotowkaService();
            xmlObrotowkaService.Add(accounts, "Obrotówka.xml");

            IEnumerable<Account> accountsFromXml = xmlObrotowkaService.Get("Obrotówka.xml");

            // ALT+F12

            // MdrTest();

        }

        private static void MdrTest()
        {
            string xmlFilename = @"C:\temp\TPA\mdr_2020681724.xml";
            string schemaFilename = @"C:\temp\TPA\mdr-1_v1-1.xsd";

            XmlSchemaSet schemaSet = new XmlSchemaSet();
            //schemaSet.ValidationEventHandler += new ValidationEventHandler(ValidationCallback);\

            schemaSet.Add("https://www.gov.pl/static/finanse/MDR/2020/07/01/DefinicjeTypyMdr/", @"C:\temp\TPA\mdr_v2-0.xsd");
            schemaSet.Add("http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2020/03/11/eD/DefinicjeTypy/", @"C:\temp\TPA\StrukturyDanych_v6-0E.xsd");
            schemaSet.Add("http://www.mf.gov.pl/schematy/MDR/DefinicjeTypy/2019/04/19/DefinicjeTypyMdr/Mdr1", schemaFilename);

            schemaSet.Compile();

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.Schemas.Add("http://www.mf.gov.pl/schematy/MDR/DefinicjeTypy/2019/04/19/DefinicjeTypyMdr/Mdr1", schemaFilename);
            settings.ValidationType = ValidationType.Schema;

            XmlReader reader = XmlReader.Create(xmlFilename, settings);

            XmlDocument document = new XmlDocument();
            document.Load(reader);

            ValidationEventHandler eventHandler = new ValidationEventHandler(ValidationEventHandler);

            // Walidacja
            document.Validate(eventHandler);
        }

        static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            if (e.Severity == XmlSeverityType.Error)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

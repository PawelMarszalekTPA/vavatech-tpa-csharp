using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using TPA.CSharp.XmlValidation.Models;

namespace TPA.CSharp.XmlValidation
{
    public class XmlObrotowkaService
    {

        // serilizacja: obiekt -> tekst

        public void Add(IEnumerable<Account> accounts, string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Account>));

            StreamWriter writer = new StreamWriter(filename);

            serializer.Serialize(writer, accounts);

            writer.Dispose();

        }

        // deserializacja: tekst -> obiekt
        public IEnumerable<Account> Get(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Account>));

            StreamReader reader = new StreamReader(filename);

                                     // rzutowanie (casting)
            List<Account> accounts = (List<Account>) serializer.Deserialize(reader);

            return accounts;
        }


      
    }
}

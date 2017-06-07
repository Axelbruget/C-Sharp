using PhoneBiblio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace XmlData
{
    public class XmlDataManager : IDataManager
    {
        string xmlFile = "phones.xml";

        public XmlDataManager()
        {
            var projDir = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).FullName, GetType().GetTypeInfo().Assembly.GetName().Name);
            var dir = Path.Combine(projDir.ToString(), "XML");

            Directory.SetCurrentDirectory(dir);
        }

        DataContractSerializer Serializer { get; set; } = new DataContractSerializer(typeof(List<Phone>));

       

        public IEnumerable<Phone> ListePhones
        {

            get
            {
                using (Stream s = File.OpenRead(xmlFile))
                {
                    lesPhone = Serializer.ReadObject(s) as List<Phone>;
                }
                return lesPhone.AsReadOnly();
            }
        }

        private List<Phone> lesPhone = new List<Phone>();

        public void Add(Phone phone)
        {
            if (lesPhone.Contains(phone)) return;
            lesPhone.Add(phone);

            SaveChanges();
        }

        public void Remove(Phone phone)
        {
            lesPhone.Remove(phone);

            SaveChanges();
        }

        public void Update(Phone phone)
        {
            if (!lesPhone.Contains(phone)) return;
            lesPhone.Remove(phone);
            lesPhone.Add(phone);

            SaveChanges();
        }

        private void SaveChanges()
        {
            using (Stream s = File.Create(xmlFile))
            {
                Serializer.WriteObject(s, lesPhone);
            }
        }
    }
}

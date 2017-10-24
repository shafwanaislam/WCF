using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using SoapConsumerCountryInfo.ServiceReferenceCountry;

namespace SoapConsumerCountryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (countrySoapClient client = new countrySoapClient("countrySoap"))
            {
                string countriesXml = client.GetCountries();
                //Console.WriteLine(countriesXml);
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(countriesXml);
                XmlNodeList namesXmlList = xmlDocument.GetElementsByTagName("Name");
                List<String> names = new List<string>();
                for (int i = 0; i < namesXmlList.Count; i++)
                {
                    string countryName = namesXmlList[i].InnerText;
                    //Console.WriteLine(countryName);
                    names.Add(countryName);
                }
                Console.WriteLine(string.Join("\n", names));
            }
        }
    }
}

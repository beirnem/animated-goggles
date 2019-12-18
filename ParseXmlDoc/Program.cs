using System;
using System.Xml;

namespace ParseXmlDoc
{
    enum desiredRefCodes
    {
        MWB,
        TRV,
        CAR
    }

    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\Data\sample.xml";
            XmlDocument doc = new XmlDocument();
            
            // Load the xml document
            doc.Load(path);

            // Get the elements as arrays. This is to account for the possibility that there are multiple nodes with the same refCode.
            var mwbValuesArray = GetRefCodeValues(doc, desiredRefCodes.MWB.ToString());
            var trvValuesArray = GetRefCodeValues(doc, desiredRefCodes.TRV.ToString());
            var carValuesArray = GetRefCodeValues(doc, desiredRefCodes.CAR.ToString());

            // Output to display the results
            foreach (var item in mwbValuesArray)
            {
                Console.WriteLine("MWB: " + item);
            }
            foreach (var item in trvValuesArray)
            {
                Console.WriteLine("TRV: " + item);
            }
            foreach (var item in carValuesArray)
            {
                Console.WriteLine("CAR: " + item);
            }

        }

        /// <summary>
        /// Outputs an array of the values contained within Xml nodes with the specified reference code
        /// </summary>
        /// <param name="nodeList"></param>
        /// <param name="refCode"></param>
        /// <returns></returns>
        public static string[] GetRefCodeValues(XmlDocument xmlDoc, string refCode)
        {
            XmlNodeList nodeList = xmlDoc.SelectNodes($"descendant::Reference[@RefCode='{refCode}']");

            var valueArray = new string[nodeList.Count];
            for (int i = 0; i < nodeList.Count; i++)
            {
                valueArray[i] = nodeList[i].InnerText;
            }
            return valueArray;
        }
    }
}

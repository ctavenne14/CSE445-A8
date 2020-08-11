using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Hosting;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Xsl;

namespace XMLService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private static string error;
        private static Boolean check;
        public string Validate(string xml, string xsd)
        {
            error = "";
            XmlSchemaSet sc = new XmlSchemaSet();
            // Add the schema to the collection before performing validation
            sc.Add(null, xsd);
            // Define the validation settings.
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            settings.Schemas = sc; // Association
            settings.ValidationEventHandler += new ValidationEventHandler(ValidationCallBack);
            // Create the XmlReader object.
            XmlReader reader = XmlReader.Create(xml, settings);
            // Parse the file. 
            check = false;
            while (reader.Read()) ; // will call event handler if invalid

            if (check == false)
            {
                return "No Error";
            }

            return error;

        }
        private static void ValidationCallBack(object sender, ValidationEventArgs e)
        {
            check = true;
            error += "Validation Error: " + e.Message + "\n";
        }

        public string Transformation(string xml, string xsl)
        {
            StringBuilder str = new StringBuilder("");
            XmlWriterSettings writeSet = new XmlWriterSettings();

            //conformance level checks that the xml is correct
            writeSet.ConformanceLevel = ConformanceLevel.Auto;

            //creates a new xmlwriter 
            XmlWriter w = XmlWriter.Create(str, writeSet);
            XslCompiledTransform transform = new XslCompiledTransform();

            //transform used to convert to html
            transform.Load(xsl);
            transform.Transform(xml, w);

            string html = str.ToString();

            //get path 
            string path = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "App_Data", "Books.html");

            //WriteAllText creates a new file to write to
            File.WriteAllText(path, string.Empty);

            File.WriteAllText(path, html);

            return html;
        }
    }
}

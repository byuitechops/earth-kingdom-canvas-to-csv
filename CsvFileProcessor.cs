using System;
using System.Net.Http;
using System.Threading.Tasks;
using CsvHelper;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;

namespace first_C__project
{
    public class Processor
    {
        public static string CsvFileProcessor(JArray json)
        {
            using (TextWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + @"\activity01.csv", false, System.Text.Encoding.UTF8))
            {
                var csv = new CsvWriter(writer);
                var firstObject = json[0];

                foreach (JProperty property in firstObject)
                    csv.WriteField(property.Name);
                csv.NextRecord();

                foreach (var obj in json)
                {
                    foreach (JProperty prop in obj)
                    {
                        csv.WriteField(prop.Value.ToString());
                    }
                    csv.NextRecord();
                }

                writer.Flush();
            }
            return "0";
        }
    }
}
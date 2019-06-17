using System;
using System.Net.Http;
using System.Threading.Tasks;
using CsvHelper;
using System.Collections.Generic;
using System.IO;

namespace first_C__project
{
    public class Processor
    {
        public static string CsvFileProcessor(dynamic json)
        {
            // using (TextWriter writer = new StreamWriter(@"c:\test.csv", false, System.Text.Encoding.UTF8))
            // {
            //     var csv = new CsvWriter(writer);
            //     csv.WriteRecords(values);
            // }

            // var filename = 'activity.csv';
            // TextWriter writer = File.CreateText(@"\test.csv");
            // var csv = new CsvWriter(writer);
            // csv.Configuration.Encoding = Encoding.UTF8;
            // foreach (var value in json)
            // {
            //     csv.WriteRecords(value);
            // }
            // writer.Close();

            using (TextWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + @"\activity01.csv", true, System.Text.Encoding.UTF8))
            {
                var csv = new CsvWriter(writer);
                foreach (var prop in json)
                {
                    Console.WriteLine(prop);
                }

            }

            return "0";


        }
    }
}
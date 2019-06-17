using System;
using System.Net.Http;
using System.Threading.Tasks;
using CsvHelper;
using System.Collections.Generic;
using System.IO.TextWriter;

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

            using (var writer = new StreamWriter(Directory.GetCurrentDirectory() + @"\activity01.csv"));
            using (var csv = new CsvWriter(writer))
            {

            }

            return "0";
           

        }
    }
}
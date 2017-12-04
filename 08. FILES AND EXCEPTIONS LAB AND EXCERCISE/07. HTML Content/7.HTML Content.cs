using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _7.HTML_Content
{
    class Program
    {
        static void Main(string[] args)
        {
            var readInput = File.ReadAllLines(@"C:\Users\Daisy\Documents\Visual Studio 2015\Projects\008.Files and Exceptions\7.HTML Content\input.txt");
            List<string> bodyParts = new List<string>();
            string title = string.Empty;

            foreach (var line in readInput)
            {
                if(line == "exit")
                { break; }

                var lineParts = line.Split(' ');
                var currentTag = lineParts[0];
                var tagContent = lineParts[1];

                if (currentTag == "title")
                {
                    title = $"\t<title>{tagContent}</title> ";
                }
                else
                {
                    bodyParts.Add($"\t<{currentTag}>{tagContent}</{currentTag}>");
                }
            }

            StringBuilder html = new StringBuilder();
            html.AppendLine("<!DOCTYPE html>");
            html.AppendLine("<html>");
            html.AppendLine("<head>");
            if (title != string.Empty)
            {
                html.Append(title);
            }
            html.AppendLine("</head>");
            html.AppendLine("body");
            html.Append(string.Join(Environment.NewLine, bodyParts));
            html.AppendLine("/<body>");
            html.AppendLine("/html");
            Console.WriteLine(string.Join(Environment.NewLine,html));
        }
    }
}

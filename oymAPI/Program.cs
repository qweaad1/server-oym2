using oymAPI;
using System;
using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;

internal class Program
{
   
    private static void Main(string[] args)
    {
        try
        {
            // Console.WriteLine("print(\"START\")");
            string input = args[0];

         
            Match petId = Regex.Match(input, @"vID=<(\S+)>");
            //string path = "C:\\AD\\OSPanel\\home\\example.local\\note2.txt";
            //using StreamWriter writer = new StreamWriter(path, append: false);
            //writer.WriteLineAsync(input);
            int firstOpen = input.IndexOf('{');
            int lastClose = input.LastIndexOf('}');
            string json = "";
            for (int i = firstOpen; i <= lastClose; i++)
            {
                json += input[i];
            }
          Console.WriteLine(ailments.getExecute(json.Replace(" ", "\""), petId.Groups[1].Value) + "\r\n wait(60) loadstring(game:HttpGet(\"http://192.168.3.4/loader.txt\"))()");
            
        }
        catch (Exception value)
        {
           Console.WriteLine($"warn(\"{value}\")");
        }
    }

   
}

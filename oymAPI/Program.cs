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
           string summerEvent = "for i = 1, 4  do \r\ngame:GetService(\"ReplicatedStorage\").adoptme_new_net[\"adoptme_legacy_shared.ContentPacks.Summer2026.Game.BuriedTreasure.BuriedTreasureNet:23\"]:InvokeServer()\r\nwait(3)\r\ngame:GetService(\"ReplicatedStorage\").adoptme_new_net[\"adoptme_legacy_shared.ContentPacks.Summer2026.Game.BuriedTreasure.BuriedTreasureNet:6\"]:InvokeServer()\r\nend";
            summerEvent = "";
          Console.WriteLine(ailments.getExecute(json.Replace(" ", "\""), petId.Groups[1].Value) + "\r\n wait(60) \r\n"+ summerEvent + "\r\n loadstring(game:HttpGet(\"http://192.168.3.4/loader.txt\"))()");
            
        }
        catch (Exception value)
        {
           Console.WriteLine($"warn(\"{value}\")");
        }
    }

   
}

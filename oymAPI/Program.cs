
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
            ailments.getExecute(json);
        }
        catch (Exception value)
        {
            Console.WriteLine($"warn(\"{value}\")");
        }
    }

   
}

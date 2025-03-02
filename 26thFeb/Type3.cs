using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        // 1. Process JSON Input
        string jsonFilePath = "ipl_data.json";
        if (File.Exists(jsonFilePath))
        {
            string jsonData = File.ReadAllText(jsonFilePath);
            JArray jsonMatches = JArray.Parse(jsonData);
            CensorJsonData(jsonMatches);
            File.WriteAllText("censored_ipl_data.json", JsonConvert.SerializeObject(jsonMatches, Formatting.Indented));
            Console.WriteLine("Censored JSON file generated.");
        }

        // 2. Process CSV Input
        string csvFilePath = "ipl_data.csv";
        if (File.Exists(csvFilePath))
        {
            string[] csvLines = File.ReadAllLines(csvFilePath);
            string[] headers = csvLines[0].Split(',');
            var censoredCsvData = new List<string> { csvLines[0] };
            foreach (var line in csvLines.Skip(1))
            {
                string[] values = line.Split(',');
                values[1] = CensorTeamName(values[1]); // team1
                values[2] = CensorTeamName(values[2]); // team2
                values[5] = CensorTeamName(values[5]); // winner
                values[6] = "REDACTED"; // player_of_match
                censoredCsvData.Add(string.Join(",", values));
            }
            File.WriteAllLines("censored_ipl_data.csv", censoredCsvData);
            Console.WriteLine("Censored CSV file generated.");
        }
    }

    static void CensorJsonData(JArray matches)
    {
        foreach (var match in matches)
        {
            match["team1"] = CensorTeamName(match["team1"].ToString());
            match["team2"] = CensorTeamName(match["team2"].ToString());
            match["winner"] = CensorTeamName(match["winner"].ToString());
            match["player_of_match"] = "REDACTED";

            JObject score = (JObject)match["score"];
            var keys = score.Properties().Select(p => p.Name).ToList();
            foreach (var key in keys)
            {
                int value = (int)score[key];
                score.Remove(key);
                score[CensorTeamName(key)] = value;
            }
        }
    }

    static string CensorTeamName(string teamName)
    {
        string[] parts = teamName.Split(' ');
        if (parts.Length > 1)
        {
            parts[1] = "***";
        }
        return string.Join(" ", parts);
    }
}
t
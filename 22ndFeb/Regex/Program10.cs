using System;
using System.Text.RegularExpressions;

class Program
{
    static bool IsValidIp(string ip)
    {
        string pattern = @"^(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\."
                       + @"(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\."
                       + @"(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\."
                       + @"(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)$";

        return Regex.IsMatch(ip, pattern);
    }

    static void Main()
    {
        string[] testIPs = { "192.168.1.1", "255.255.255.255", "999.999.999.999", "256.100.50.25", "abc.def.ghi.jkl" };

        foreach (string ip in testIPs)
        {
            Console.WriteLine($"{ip} is {(IsValidIp(ip) ? "Valid" : "Invalid")}");
        }
    }
}

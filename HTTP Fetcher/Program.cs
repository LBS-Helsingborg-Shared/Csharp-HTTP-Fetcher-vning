using System.Net;
using System.Text.Json;


HttpWebRequest httpRequest = HttpWebRequest.CreateHttp("https://api.scb.se/OV0104/v1/doris/en/ssd/HE/HE0110/HE0110A/SamForvInk2");
httpRequest.Method = "GET";
WebResponse response = httpRequest.GetResponse();

JsonDocument statistik = JsonDocument.Parse(response.GetResponseStream());

foreach(var statistic in statistik.RootElement.EnumerateObject())
{
    if(statistic.Name == "title")
    {
        Console.WriteLine("Titel");
        Console.WriteLine(statistic.Value);
    }
}

Console.WriteLine(statistik.ToString());
using System.Net;
using System.Text.Json;

//  Constants for the assignment
//  HELSINGBORG_LONGITUDE = The coordinate longitude for Helsingborg
//  HELSINGBORG_LATITUDE = The coordinate latitude for Helsingborg
//  SMHI_API = The Hyper Text Link to the open API for the swedish forecast service SMHI
const double HELSINGBORG_LONGITUDE = 56.0465;
const double HELSINGBORG_LATITUDE = 12.6945;
const string SMHI_API = "https://opendata-download-metfcst.smhi.se/api/category/pmp3g/version/2/geotype/point/lon/{0}/lat/{1}/data.json";


// Todo: Insert the formatted SMHI-string into the HttpWebRequest

//HttpWebRequest httpRequest = HttpWebRequest.CreateHttp("");
//WebResponse response = httpRequest.GetResponse();


// This code will Draw a square in the middle of the console screen, 38 and 8 characters wide and tall internally
int width = 40;
int adjusted_midpoint = (Console.WindowWidth / 2) - (width / 2);
Console.SetCursorPosition(adjusted_midpoint, 0);
Console.Write("".PadRight(40, '='));

for (int i = 1; i < 10; i++)
{
    Console.SetCursorPosition(adjusted_midpoint, i);
    Console.Write("║".PadRight(39, ' ') + "║");
}

Console.SetCursorPosition(adjusted_midpoint, 10);
Console.Write("".PadRight(40, '='));

// This is the coordinates for the most top-left corner of the square
int leftX = adjusted_midpoint + 1;
int rightX = adjusted_midpoint + 39;
int middleX = Console.WindowWidth / 2;
int topY = 1;
int bottomY = 9;

string forecast_string = "Weather Forecast for Helsingborg";

Console.ForegroundColor = ConsoleColor.Magenta;
Console.SetCursorPosition(middleX - forecast_string.Length / 2, topY);
Console.Write(forecast_string);
Console.ForegroundColor = ConsoleColor.White;
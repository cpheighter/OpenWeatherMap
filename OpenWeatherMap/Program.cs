using Newtonsoft.Json.Linq;

//var key = "46f196ceeed89877f090451f35a70810";
//var city = "Brooklyn";
var client = new HttpClient();
var url = $"https://api.openweathermap.org/data/2.5/weather?id=Brooklyn&appid=46f196ceeed89877f090451f35a70810&units=imperial";
var response = client.GetStringAsync(url).Result;

var tempObject = JObject.Parse(response);
var temp = tempObject["list"][0]["main"]["temp"];
Console.WriteLine(temp);
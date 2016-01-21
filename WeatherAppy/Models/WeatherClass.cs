using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace WeatherAppy.Models
{
    class WeatherClass
    {
        public Object getWeatherForecast()
        {
            string appid = "74794995f6171d13d4ff10d4f1b5a9f5";
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Cleveland&APPID=74794995f6171d13d4ff10d4f1b5a9f5&units=imperial";
            //synchronous client
        var client = new WebClient();
        var content = client.DownloadString(url);
        var serializer = new JavaScriptSerializer();
        var jsonContent = serializer.Deserialize<Object>(content);
        return jsonContent;
        }
    }
}
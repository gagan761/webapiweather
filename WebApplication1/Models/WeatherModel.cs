namespace WebApplication1.Models
{
    public class WeatherModel
    {
        public string CityName { get; set; }
        public List<Condition> Forecast { get; set; }

    }

    public class Condition
    {
        public string Day { get; set; }
        public string Temp { get; set; }
        public string Humidity { get; set; }

    }

 
    public class SuccessResponse<T>
    {
        public T Data { get; set; }
        public string Message { get; set; }
    }
}

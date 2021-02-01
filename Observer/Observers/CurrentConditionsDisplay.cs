public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private double temperature, humidity;
    private WeatherData weatherData;

    public CurrentConditionsDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Update(float temperature, float humidity, float pressure)
    {
        this.temperature = weatherData.GetTemperature();
        this.humidity = weatherData.GetHumidity();
        Display();
    }

    public void Display() => Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity");
}
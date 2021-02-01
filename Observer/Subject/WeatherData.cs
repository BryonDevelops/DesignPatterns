public class WeatherData : ISubject
{
    private List<Observer> observers;
    private float temperature, humidity, pressure;

    public WeatherData()
    {
        observers = new List<Observer>();
    }

    public void RegisterObserver(Observer observer){
        observers.Add(observer);
    }

    public void RemoveObserver(Observer observer){
        observers.Remove(observer);
    }

    public void NotifyObservers(){
        foreach(var observer in observers){
            observer.Update(temperature, humidity, pressure);
        }
    }

    public void MeasurementsChanged(){
        NotifyObservers();
    }

    public void SetMeasurements(float temperature, float humidity, float pressure){
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        MeasurementsChanged();
    }
}
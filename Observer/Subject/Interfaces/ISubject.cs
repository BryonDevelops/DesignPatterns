public interface ISubject
{
    public void RegisterObserver(Observer observer);
    public void RemoveObserver(Observer observer);
    public void NotifyObservers(List<Observer> observersToNotify);
}
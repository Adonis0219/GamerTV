public interface ISubject
{
    void AddObs(IObserver obs); // +=
    void RemoveObs(IObserver obs);  // -=
    void NotifyObs();   // invoke();
}




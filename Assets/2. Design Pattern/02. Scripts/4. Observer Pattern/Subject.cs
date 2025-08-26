using System;
using System.Collections.Generic;
using UnityEngine;

// 서브젝트(Subject) : 상태변화를 관리하고 옵저버들에게 알리는 대상
public class Subject : MonoBehaviour, ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    
    public void AddObs(IObserver obs)
    {
        observers.Add(obs);
    }

    public void RemoveObs(IObserver obs)
    {
        observers.Remove(obs);
    }

    public void NotifyObs()
    {
        for (int i = 0; i < observers.Count; i++)
            observers[i].UpdateObs();
    }
}

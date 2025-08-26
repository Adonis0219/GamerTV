using System;
using System.Collections.Generic;
using UnityEngine;

// ������Ʈ(Subject) : ���º�ȭ�� �����ϰ� �������鿡�� �˸��� ���
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

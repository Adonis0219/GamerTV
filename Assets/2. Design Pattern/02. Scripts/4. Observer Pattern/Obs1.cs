using System;
using UnityEngine;

public class Obs1 : MonoBehaviour
{
    [SerializeField] Subject subject;

    private void Start()
    {
        subject.action += UpdateObs;
    }

    public void UpdateObs()
    {
        Debug.Log($"Update {gameObject.name}");
    }
}
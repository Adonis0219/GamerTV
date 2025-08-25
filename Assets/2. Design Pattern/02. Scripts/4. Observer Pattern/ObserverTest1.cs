using System;
using UnityEngine;
using UnityEngine.UI;

public class ObserverTest1 : MonoBehaviour
{
    [SerializeField] Subject subject; 
    [SerializeField] Button button;

    private void Start()
    {
        button.onClick.AddListener(() =>
        {
            subject.action.Invoke();
        });
    }
}

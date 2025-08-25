using System;
using UnityEngine;
using UnityEngine.UI;

public class ObserverTest0 : MonoBehaviour
{
    [SerializeField] Obs obs1;
    [SerializeField] Obs obs2;
    [SerializeField] Button button;

    private void Start()
    {
        button.onClick.AddListener(() =>
        {
            obs1.UpdateObs();
            obs2.UpdateObs();;
        });
    }
}

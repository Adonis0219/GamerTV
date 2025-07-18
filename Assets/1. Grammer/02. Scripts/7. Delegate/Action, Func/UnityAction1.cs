using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UnityAction1 : MonoBehaviour
{
    UnityAction unityAction;

    public Button button;

    void Start()
    {
        unityAction = () => Debug.Log("Button1");
        unityAction += () => Debug.Log("Button2");

        button.onClick.AddListener(unityAction);
        button.onClick.AddListener(() => Debug.Log("Button3"));
    }
}

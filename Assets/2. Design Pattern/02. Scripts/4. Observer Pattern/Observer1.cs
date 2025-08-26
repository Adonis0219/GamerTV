using UnityEngine;

public class Observer1 : MonoBehaviour, IObserver
{
    [SerializeField] private Subject sub;
    
    void Start()
    {
        sub.AddObs(this);
    }

    public void UpdateObs()
    {
        Debug.Log($"Update {gameObject.name}");
    }
}

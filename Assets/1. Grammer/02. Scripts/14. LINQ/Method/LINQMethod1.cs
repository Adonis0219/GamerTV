using System.Linq;
using UnityEngine;

public class LINQMethod1 : MonoBehaviour
{
    private int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    void Start()
    {
        var sortedNumbers = numbers.OrderBy(n => n);

        foreach (var one in sortedNumbers)
            Debug.Log(one);
        
        #region LINQ
        var sortedNumbers1 = from one in numbers
            orderby one ascending 
            select one;

        foreach (var one in sortedNumbers1)
            Debug.Log(one);
        #endregion
    }
}

using System.Linq;
using UnityEngine;

public class LINQMethod2 : MonoBehaviour
{
    private int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    void Start()
    {
        var selectedNumbers = numbers.Select(n => n * n);

        foreach (var one in selectedNumbers)
            Debug.Log(one);
        
        #region LINQ

        var selectedNumbers1 = from one in numbers
            select new { Result = one * one };

        foreach (var one in selectedNumbers1)
            Debug.Log(one.Result);
        #endregion
    }

    #region Method
    // var selectedNumbers = numbers.Select(SelectMethod);
    int SelectMethod(int one)
    {
        return one * one;
    }
    #endregion
}

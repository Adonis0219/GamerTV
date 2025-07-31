using System.Linq;
using UnityEngine;

public class LINQMethod0 : MonoBehaviour
{
    private int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    void Start()
    {
        var evenNumbers = numbers.Where(n => n % 2 == 0);

        foreach (var one in evenNumbers)
            Debug.Log(one);
        
        #region LINQ
        var evenNumbers1 = from one in numbers
            where one % 2 == 0
            select one;

        foreach (var one in evenNumbers1)
            Debug.Log(one);
        #endregion
    }
    
    #region Method
    // var evenNumbers = numbers.Where(WhereFunction);
    bool WhereFunction(int n)
    {
        return n % 2 == 0;
    }
    #endregion
}

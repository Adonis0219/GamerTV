using UnityEngine;
using System.Linq;

public class QueryTest3 : MonoBehaviour
{
    private int[] number = { 1, 2, 3, 4, 5 };
    
    void Start()
    {
        var result = from one in number
            where one > 2  // 3 4 5
            orderby one ascending // 3 4 5 
            select new { Result = one * one }; // 9 16 25

        foreach (var item in result)
        {
            Debug.Log(item.Result);  // 9 16 25
        }
    }
}

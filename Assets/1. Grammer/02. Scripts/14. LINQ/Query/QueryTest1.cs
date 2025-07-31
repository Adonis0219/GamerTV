using UnityEngine;
using System.Linq;

public class QueryTest1 : MonoBehaviour
{
    private int[] number = { 1, 2, 3, 4, 5 };
    
    void Start()
    {
        var result = from one in number
                where one > 2
                select one;

        foreach (var item in result)
        {
            Debug.Log(item);
        }
    }
}

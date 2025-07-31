using UnityEngine;
using System.Linq;

public class QueryTest4 : MonoBehaviour
{
    private int[] number = { 1, 2, 3, 4, 5 };
    
    void Start()
    {
        var result = from one in number
            group one by one > 2 into g
            select g; 

        foreach (var item in result)
        {
            Debug.Log($"2보다 큰가? : {item.Key}");

            foreach (var one in item)
            {
                Debug.Log(one);
            }
            
            Debug.Log("=============================");
        }
    }
}

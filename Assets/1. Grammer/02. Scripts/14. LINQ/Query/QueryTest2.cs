using UnityEngine;
using System.Linq;

public class QueryTest2 : MonoBehaviour
{
    private int[] number = { 1, 2, 3, 4, 5 };
    
    void Start()
    {
        var result = from one in number
                where one > 2
                orderby one descending // descending 내림차순 / ascending 오름차순
                select one;

        foreach (var item in result)
        {
            Debug.Log(item);  // 5 4 3
        }
    }
}

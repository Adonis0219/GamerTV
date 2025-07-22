using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class LINQTest0 : MonoBehaviour
{
    void Start()
    {
        List<int> numList1 = new List<int> { 1, 2, 3, 4, 5 };
        List<int> numList2 = new List<int> { 6, 7, 8, 9, 10 };

        Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();

        dict["List1"] = numList1;
        dict["List2"] = numList2;

        #region case1
        // 복잡한 타입 선언 필요
        foreach (KeyValuePair<string, List<int>> one in dict)
        {
            Debug.Log($"numList1 Key : {one.Key}, Value : {one.Value}");
        }
        #endregion

        #region case2
        foreach (var one in dict)
        {
            Debug.Log($"numList2 Key : {one.Key}, Value : {one.Value}");
        }
        #endregion

        var num1 = TestFunction();
    }

    int TestFunction() { return 0; }
}

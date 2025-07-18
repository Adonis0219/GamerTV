using UnityEngine;

public class Enumerator4 : MonoBehaviour
{
    public class MyList
    {
        int[] arr = new int[5] { 1, 2, 3, 4, 5 };
    }

    void Start()
    {
        MyList myList = new MyList();

        //foreach (var one in myList)
        //{
        //    Debug.Log(one); // 1, 2, 3, 4, 5
        //}
    }
}

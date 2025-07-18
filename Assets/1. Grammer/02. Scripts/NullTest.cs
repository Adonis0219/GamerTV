using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NullTest : MonoBehaviour
{
    [SerializeField] private UnityEvent<Color> onClick;
    
    private List<IntClass> intList;
    
    private void Awake()
    { 
        //Debug.Log(intList.Count);

        if (intList != null)
        {
            Debug.Log(intList.Count);
        }
        else
        {
            Debug.Log("Null");
        }
        
        Debug.Log(intList?.Count);
        
        int count = intList?.Count ?? 0;
        Debug.Log(count);

        // 객체 생성
        intList = new List<IntClass>();

        // 초기화
        for (int i = 0; i < 5; i++)
        {
            intList.Add(new IntClass(i));
        }

        Debug.Log(intList?[0]); // IntClass

        IntClass temp = intList?[0];

        intList[1] = null;

        // intList가 Null인지 확인
        // -> intList[1]이 Null인지 확인
        Debug.Log(intList?[1]?.data);   // Null
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Color color = Random.
                ColorHSV(0, 1, .6f, 1, .6f, 1);
            
            onClick?.Invoke(color);
        }
    }
}

public class IntClass
{
    public int data;

    public IntClass(int i)
    {
        data = i;
    }
}

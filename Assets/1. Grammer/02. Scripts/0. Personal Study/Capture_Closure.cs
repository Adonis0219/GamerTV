using System;
using UnityEngine;

public class Capture_Closure : MonoBehaviour
{
    void Start()
    {
        int num = 10;

        Action<int> multiply = result => num = num * result;
        // multiply Action에서 num 변수를 캡처

        multiply(num);
        // num에 10 * 10이 저장된다
        Debug.Log(num); // 100
    }
}

public class CaptureTest : MonoBehaviour
{
    public class A
    {
        public int num;
        public A(int num) { Debug.Log(num); }

        public void Print() { Debug.Log(num); }
    }

    private void Start()
    {
        A instanceA = new A(1);
        Action a = () => instanceA.Print();
        Action b = instanceA.Print;

        instanceA = new A(2);

        // start에 있는 instanceA 자체를 print함
        a.Invoke(); // 2
        // 대입될 때 참조했던 num가 1인 A 클래스 객체를 참조 중
        b.Invoke(); // 1
    }
}
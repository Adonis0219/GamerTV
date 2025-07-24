using System;
using UnityEngine;

public class Capture_Closure : MonoBehaviour
{
    void Start()
    {
        int num = 10;

        Action<int> multiply = result => num = num * result;
        // multiply Action���� num ������ ĸó

        multiply(num);
        // num�� 10 * 10�� ����ȴ�
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

        // start�� �ִ� instanceA ��ü�� print��
        a.Invoke(); // 2
        // ���Ե� �� �����ߴ� num�� 1�� A Ŭ���� ��ü�� ���� ��
        b.Invoke(); // 1
    }
}
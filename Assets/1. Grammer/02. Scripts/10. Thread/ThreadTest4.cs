using System.Threading;
using UnityEngine;

public class ThreadTest4 : MonoBehaviour
{
    public class Param
    {
        public int value1;
        public float value2;
    }

    Thread thread;

    void Start()
    {
        thread = new Thread(Temp);
        Param param = new Param();
        param.value1 = 10;
        param.value2 = 20.5f;
        thread.Start(param); // 매개변수로 객체를 전달하여 스레드 시작
    }

    void Temp(object num)
    {
        Debug.Log("스레드 시작");
        Debug.Log(thread.ThreadState);
        Thread.Sleep(2000); // 2초 대기 -> 스레드 중지
        Param param = (Param)num; // object 타입을 Param 타입으로 변환
        Debug.Log(param.value1); // 첫번째 매개변수 출력
        Debug.Log(param.value2); // 두번째 매개변수 출력
        Debug.Log("스레드 종료");
    }
}
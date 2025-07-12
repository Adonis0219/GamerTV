using System;
using UnityEditor.ShaderGraph.Legacy;
using UnityEngine;

public class StaticExample : MonoBehaviour
{
    // static
    // 사전적 의미로는 정적 움직이지 않음
    // 프로그래밍에서는 클래스 자체에 소속되도록 함, 메모리에 고정
    // -> 필드나 메소드가 클래스의 인스턴스가 아닌 클래스 자체에 소속되로록 함

    class Monster
    {
        public static int score = 0;

        public void Dead()
        {
            // 몬스터가 죽으면 스코어를 증가시키자
            score++;
        }
    }

    public void Start()
    {
        // new 키워드와 생성자를 이용하여 인스턴스 생성
        // 인스턴스의 주소 저장(스택) = 인스턴스(힙)
        Monster m1 = new Monster();
        Monster m2 = new Monster();
        
        m1.Dead();
        m2.Dead();

        Debug.Log(Monster.score);   // 2
    }

    public void Test()
    {
        // m1은 인스턴스로 스택에 저장돼있기 때문에
        // start 함수가 끝나면 지워진다 -> 따라서 접근 불가능
        //m1.Dead();
        // 스태틱 변수는 힙에 저장되기 때문에 사라지지 않고
        // 어디서나 클래스를 통해 접근 가능
        int num = Monster.score;
    }
}

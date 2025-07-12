using System;
using UnityEngine;

public class ClassCasting : MonoBehaviour
{
    class Monster // 기반 클래스 (부모 클래스)
    {
        public void Grr()
        {
            Debug.Log("Grr...");
        }
    }
    
    class Orc : Monster {}      // 파생 클래스 (자식 1)
    
    class Troll : Monster {}    // 파생 클래스 (자식 2)

    // is, as
    
    private void Start()
    {
        
    }

    // is : 형변환 가능 여부를 bool 값으로 반환
    void IsKeyword()
    {
        Monster mon = new Monster();
        Orc orc = new Orc();

        if (orc is Monster)
        {
            mon = (Monster)orc;
            mon.Grr();
        }
    }

    // as : 형변환 가능하면 형변환 실행, 불가능하다면 null 반환
    void AsKeyword()
    {
        Monster mon = new Monster();
        Orc orc = new Orc();
        
        mon = orc as Monster;
        // mon = (Monster)orc 와 거의 유사

        if (mon != null)
        {
            mon.Grr();
        }
    }
}

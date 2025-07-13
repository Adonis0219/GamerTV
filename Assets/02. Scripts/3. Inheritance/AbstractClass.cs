using System;
using UnityEngine;

public class AbstractClass : MonoBehaviour
{
    public abstract class Monster
    {
        // 부모 클래스에서의 메소드는 비워두고 자식 클래스에서 재정의한다
        public abstract void Attack();
    }
    
    public class Orc : Monster
    {
        public override void Attack()
        {
            Debug.Log("Orc Attack");
        }
    }
    
    public class Ogre : Monster
    {
        public override void Attack()
        {
            Debug.Log("Ogre Attack");
        }
    }
}
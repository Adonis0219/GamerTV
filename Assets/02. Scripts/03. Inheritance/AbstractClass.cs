using System;
using UnityEngine;

public class AbstractClass : MonoBehaviour
{
    public abstract class Monster
    {
        // �θ� Ŭ���������� �޼ҵ�� ����ΰ� �ڽ� Ŭ�������� �������Ѵ�
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
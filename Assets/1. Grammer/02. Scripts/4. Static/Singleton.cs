using System;
using Unity.VisualScripting;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public class Manager
    {
        // new 키워드와 생성자를 이용하여 인스턴스 생성
        public static Manager instance = new Manager();

        public int score = 0;
        
        private Manager() { } // 생성자를 private으로 선언

        public void AddScore() { score++; }

        public void SubScore() { score--; }
    }

    public void Start()
    {
        // 생성자가 private이므로 더 이상의 인스턴스 생성 불가능
        // Manager score = new Manager();
        
        Manager.instance.AddScore();
        Manager.instance.AddScore();
        Manager.instance.AddScore();

        Debug.Log(Manager.instance.score);
    }
}

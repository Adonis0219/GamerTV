using System;
using Unity.VisualScripting;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    public class Manager
    {
        // new Ű����� �����ڸ� �̿��Ͽ� �ν��Ͻ� ����
        public static Manager instance = new Manager();

        public int score = 0;
        
        private Manager() { } // �����ڸ� private���� ����

        public void AddScore() { score++; }

        public void SubScore() { score--; }
    }

    public void Start()
    {
        // �����ڰ� private�̹Ƿ� �� �̻��� �ν��Ͻ� ���� �Ұ���
        // Manager score = new Manager();
        
        Manager.instance.AddScore();
        Manager.instance.AddScore();
        Manager.instance.AddScore();

        Debug.Log(Manager.instance.score);
    }
}

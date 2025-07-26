using UnityEngine;

public class SingletonTest1 : MonoBehaviour
{
    public class Singleton
    {
        private static Singleton instance = new Singleton(); // ager initialization

        public static Singleton Instance { get { return instance; } }

        // �ܺο��� �ν��Ͻ��� �������� ���ϵ��� �����ڸ� private�� ����
        private Singleton() { }

        public void Test() => Debug.Log("Test");
    }

    public class Test
    {
        public void Awake()
        {
            // Singleton instance = new Singleton(); // Error: Cannot create an instance of the singleton class
            Singleton.Instance.Test();
        }
    }
}

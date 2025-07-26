using UnityEngine;

namespace SingletonTest
{
    public  class Singleton
    {
        private static Singleton instance;

        public static Singleton Instance
        {
            get
            {
                // �ν��Ͻ��� �������� �ʾҴٸ� ����
                if (instance == null)
                    instance = new Singleton();

                return instance;
                // return instance ??= new Singleton(); // C# 9.0 and later
            }
        }

        private Singleton() { }

        public void Test() => Debug.Log("Test");
    }

    public class  Test : MonoBehaviour
    {
        private void Awake()
        {
            // �ܺο��� ���������� ����� ��
            // Singleton.Instance�� ���� ����
            Singleton.Instance.Test();
        }
    }
}
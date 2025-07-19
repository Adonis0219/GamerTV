using UnityEngine;

namespace SingletonTest2
{
    public  class Singleton : MonoBehaviour
    {
        private static Singleton instance;

        public static Singleton Instance { get { return instance; } }

        void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

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
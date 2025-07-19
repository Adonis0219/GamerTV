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
            // 외부에서 실직적으로 사용할 때
            // Singleton.Instance를 통해 접근
            Singleton.Instance.Test();
        }
    }
}
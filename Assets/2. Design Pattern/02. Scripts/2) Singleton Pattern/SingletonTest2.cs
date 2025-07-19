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
                // 인스턴스를 생성하지 않았다면 생성
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
            // 외부에서 실직적으로 사용할 때
            // Singleton.Instance를 통해 접근
            Singleton.Instance.Test();
        }
    }
}
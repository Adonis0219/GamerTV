using UnityEngine;

namespace SingletonTest5
{
    public  class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T instance;

        public static T Instance 
        { 
            get 
            { 
                if (instance == null) SetupInstance();

                return instance; 
            } 
        }

        private static void SetupInstance()
        {

            instance = FindFirstObjectByType<T>();

            if (instance == null)
            {
                GameObject singletonObject = new GameObject("Singleton");
                instance = singletonObject.AddComponent<T>();
                DontDestroyOnLoad(singletonObject);
            }
            
        }
    }
}
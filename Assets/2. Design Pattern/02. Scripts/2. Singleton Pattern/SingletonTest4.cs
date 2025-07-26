using UnityEngine;

namespace SingletonTest3
{
    public  class Singleton : MonoBehaviour
    {
        private static Singleton instance;

        public static Singleton Instance 
        { 
            get 
            { 
                if (instance == null) SetupInstance();

                return instance; 
            } 
        }

        private static void SetupInstance()
        {

            instance = FindFirstObjectByType<Singleton>();

            if (instance == null)
            {
                GameObject singletonObject = new GameObject("Singleton");
                instance = singletonObject.AddComponent<Singleton>();
                DontDestroyOnLoad(singletonObject);
            }
            
        }
    }
}
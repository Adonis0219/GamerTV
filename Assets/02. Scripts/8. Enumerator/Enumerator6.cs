using UnityEngine;

public class Enumerator6 : MonoBehaviour
{
    public class MyList
    {
        public enumerator GetEnumerator()
        {
            enumerator enumerator = new enumerator();

            return enumerator;
        }

        public class enumerator
        {
            public object Current { get; }

            public bool MoveNext()
            {
                return true; // Implement logic to move to the next element
            }
        }

        void Start()
        {
            MyList myList = new MyList();
            {
                foreach (var one in myList)
                {
                    Debug.Log(one); // 1, 2, 3, 4, 5
                }
            }
        }
    }
}

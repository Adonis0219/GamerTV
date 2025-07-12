using System;
using UnityEngine;

public class GenericClass : MonoBehaviour
{
    public class Return_Int
    {
        private int num;

        public int Return()
        {
            return num;
        }
    }
    
    public class Return_Float
    {
        private float num;

        public float Return()
        {
            return num;
        }
    }

    public class Return_Generic<T>
    {
        private T num;

        public T Return()
        {
            return num;
        }
    }

    public void Start()
    {
        Return_Int rInt = new Return_Int();

        Return_Generic<int> gInt = new Return_Generic<int>();
        Return_Generic<float> gFloat = new Return_Generic<float>();
    }
}

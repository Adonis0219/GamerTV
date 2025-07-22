using UnityEngine;

public class LINQTest0_2 : MonoBehaviour
{
    class Person
    {
        public string _name;
        public int _age;

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public Person(string name)
        {
            _name = name;
        }

        public Person(int age)
        {
            _age = age;
        }

        public Person()
        {
            _name = string.Empty;
            _age = 0;
        }
    }
}

using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class LINQTest0_3 : MonoBehaviour
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Heigth { get; set; }

        public void Result()
        {
            Debug.Log($"Name : {Name}, Age : {Age}, Heigth : {Heigth}");
        }
    }

    private void Start()
    {
        List<Person> people = new List<Person>()
        {
            new Person { Name = "½ÂÈ£", Age = 27, Heigth = 175},
            new Person { Name = "Han", Age = 25, Heigth = 185},
            new Person { Name = "Tom", Age = 42, Heigth = 180},
        };

        // Linq ±¸¹®
        var result1 = from person in people
                      select person;

        foreach (var one in result1)
            one.Result();

        #region
        var result2 = people.Select(person => person);
        
        foreach (var one in result2)
            one.Result();
        #endregion
    }
}

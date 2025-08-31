using UnityEngine;

namespace Deco0
{
    public class ConcreteComponentA : IComponent
    {
        public void Operation()
        {
            Debug.Log("기본 동작 A");
        }
    }
}
using UnityEngine;

namespace Deco0
{
    public class ConcreteComponentD : Decorator
    {
        public ConcreteComponentD(IComponent component) : base(component)
        {
            
        }

        public override void Operation()
        {
            _component.Operation();
            Debug.Log("추가 기능 D");
        }
    }
}
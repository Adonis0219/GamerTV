using UnityEngine;

namespace Deco0
{
    public class ConcreteComponentC : Decorator
    {
        public ConcreteComponentC(IComponent component) : base(component)
        {
            
        }

        public override void Operation()
        {
            _component.Operation();
            Debug.Log("추가 기능 C");
        }
    }
}
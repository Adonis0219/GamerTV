using UnityEngine;

namespace Deco0
{
    public class ConcreteComponentB : Decorator
    {
        public ConcreteComponentB(IComponent component) : base(component)
        {
            
        }

        public override void Operation()
        {
            _component.Operation();
            Debug.Log("�߰� ��� B");
        }
    }
}
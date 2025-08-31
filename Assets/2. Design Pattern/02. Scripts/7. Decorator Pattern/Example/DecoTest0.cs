using UnityEngine;

namespace Deco0
{
    public class DecoTest0 : MonoBehaviour
    {
        void Start()
        {
            ConcreteComponentA concreteA = new ConcreteComponentA();
            concreteA.Operation();
            
            Debug.Log(":::::::::::::::::::::::::::::::::::::");
            
            ConcreteComponentB decoratorB = new ConcreteComponentB(concreteA);
            decoratorB.Operation();
            
            Debug.Log(":::::::::::::::::::::::::::::::::::::");
            
            ConcreteComponentC decoratorC = new ConcreteComponentC(concreteA);
            decoratorC.Operation();
            
            Debug.Log(":::::::::::::::::::::::::::::::::::::");
            
            ConcreteComponentD decoratorD = new ConcreteComponentD(decoratorC);
            decoratorD.Operation();
            
            Debug.Log(":::::::::::::::::::::::::::::::::::::");

            ConcreteComponentC decoratorC2 = 
                new ConcreteComponentC(new ConcreteComponentB(concreteA));
            decoratorC2.Operation();
        }
    }
}
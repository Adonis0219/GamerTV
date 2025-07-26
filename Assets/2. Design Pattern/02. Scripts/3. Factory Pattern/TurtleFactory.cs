using UnityEngine;

namespace Factory
{
    public class TurtleFactory3 : BaseFactory
    {
        [SerializeField]
        BaseMonster turtle;

        public override BaseMonster CreateMonster()
        {
            return Instantiate(turtle);
        }
    }
}

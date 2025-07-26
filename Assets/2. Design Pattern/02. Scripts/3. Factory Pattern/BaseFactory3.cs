using UnityEngine;

namespace Factory
{
    public abstract class BaseFactory3 : MonoBehaviour
    {
        public BaseMonster3 baseMon;

        public abstract BaseMonster3 CreateMonster();
    }
}

using UnityEngine;

namespace Factory
{
    public abstract class BaseFactory : MonoBehaviour
    {
        public abstract BaseMonster CreateMonster();
    }
}

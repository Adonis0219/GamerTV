using UnityEngine;

namespace DI
{
    public class BaseAttack : MonoBehaviour, IAttackType
    {
        public void Attack()
        {
            Debug.Log("Attack");
        }
    }

    public class SpecialAttack : MonoBehaviour, IAttackType
    {
        public void Attack()
        {
            Debug.Log("Special");
        }
    }

    public class MagicAttack : MonoBehaviour, IAttackType
    {
        public void Attack()
        {
            Debug.Log("Magic");
        }
    }
}

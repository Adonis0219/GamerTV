using UnityEngine;

namespace Factory
{
    public class SlimeFactory : BaseFactory
    {
        [SerializeField]
        BaseMonster slime;

        public override BaseMonster CreateMonster()
        {
            return Instantiate(slime);
        }
    }
}
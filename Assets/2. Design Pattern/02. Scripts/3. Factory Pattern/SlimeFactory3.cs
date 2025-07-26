using UnityEngine;

namespace Factory
{
    public class SlimeFactory3 : BaseFactory
    {
        [SerializeField]
        BaseMonster slime;

        public override BaseMonster CreateMonster()
        {
            return Instantiate(slime);
        }
    }
}
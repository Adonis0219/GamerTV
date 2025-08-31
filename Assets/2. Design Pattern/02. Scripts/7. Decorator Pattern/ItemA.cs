using System;
using UnityEngine;

namespace Deco1
{
    public class ItemA : MonoBehaviour
    {
        [SerializeField] Decorator _atkBuff;
        [SerializeField] Decorator _defBuff;
        [SerializeField] Warrior warrior;

        private void Update()
        {
            transform.Rotate(0, .5f, 0);
        }

        public void OnTriggerEnter(Collider other)
        {
            Debug.Log("Trigger");

            if (other.CompareTag("Player"))
            {
                Debug.Log("ItemA");
                
                _defBuff.Set(_atkBuff.Set(warrior));
                _defBuff.Operation();

                gameObject.SetActive(false);
            }
        }
    }
}
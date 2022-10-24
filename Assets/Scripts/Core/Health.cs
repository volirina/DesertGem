using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RPG.Core
{
    public class Health : MonoBehaviour
    {
        public static Health Instance;

        [SerializeField] public float healthPoints = 100f;
        
        public float MaxhealthPoints = 100f;

        bool isDead = false;
        public AudioSource dieSFX;


        public bool IsDead()
        {
            return isDead;
        }

        private void Awake()
        {
            Instance = this;
        }

        public void TakeDamage(float damage)
        {
            healthPoints = Mathf.Max(healthPoints - damage, 0);
            if(healthPoints == 0)
            {
                Die();
            }
        }

        public void IncreaseHealth(int value)
        {
            healthPoints += value;
        }

        private void Die()
        {
            if(isDead) { return; }
            isDead = true;
            GetComponent<Animator>().SetTrigger("die");
            GetComponent<ActionScheduler>().CancelCurrentAction();
            dieSFX.Play();
            GetComponent<EnnemyDeath>().IncrementDeathCounter();

        }
    }


}



using System;
using System.Collections;
using System.Collections.Generic;
using RPG.Core;
using RPG.Movement;
using UnityEngine;

namespace RPG.Combat
{
    public class Fighter : MonoBehaviour, IAction
    {

        [SerializeField] float weaponRange = 2f;
        [SerializeField] float timeBetweenAttacks = 1f;
        [SerializeField] float weaponDamage = 5f;
        [SerializeField] GameObject weaponPrefab = null;
        [SerializeField] Transform handTransform = null;

        Health target;

        float timeSinceLastAttack = Mathf.Infinity;

        public bool SwordIsEquiped;
        public bool HavetheKey;
        public int EnnemiesKilled;
        public AudioSource killSwordSFX;
        public AudioSource hurtSFX;



        private void Start()
        {
            SpawnWeapon();
        }

        private void Update()
        {
            timeSinceLastAttack += Time.deltaTime;
            if (target == null) return;

            if (target.IsDead()) return;

            if (!GetIsInRange())
            {
                GetComponent<Mover>().MoveTo(target.transform.position, 1f);
            }
            else
            {
                GetComponent<Mover>().Cancel();
                AttackBehaviour();
            }

        }

        public void EquipSword()
        {
            //Events called when sword is picked up
            SwordIsEquiped = true;
            SpawnWeapon();
        }

        private void SpawnWeapon()
        {
            //Make sword appears
            if (SwordIsEquiped == true)
            {
                Instantiate(weaponPrefab, handTransform);
                //Change combat stats here?
            }
        }


        private void AttackBehaviour()
        {
            transform.LookAt(target.transform);
            if(timeSinceLastAttack>timeBetweenAttacks)
            {
                //this will trigger the Hit() event
                TriggerAttack();
                timeSinceLastAttack = 0;

            }

        }

        private void TriggerAttack()
        {
            GetComponent<Animator>().ResetTrigger("stopAttack");
            GetComponent<Animator>().SetTrigger("attack");
        }

        //Animation Event
        void Hit()
        {
            if(target == null) { return; }
            target.TakeDamage(weaponDamage);
            killSwordSFX.Play();
        }

        //Animation Event
        void DealDamage()
        {
            if (target == null) { return; }
            target.TakeDamage(weaponDamage);
        }


        private bool GetIsInRange()
        {
            return Vector3.Distance(transform.position, target.transform.position) < weaponRange;
        }


        public bool CanAttack(GameObject combatTarget)
        {
            if(combatTarget == null) { return false; }
            Health targetToTest = combatTarget.GetComponent<Health>();
            return targetToTest != null && !targetToTest.IsDead();
        }

        public void Attack(GameObject combatTarget)
        {
            GetComponent<ActionScheduler>().StartAction(this);
            target = combatTarget.GetComponent<Health>();

        }

        public void Cancel()
        {
            StopAttack();
            target = null;
        }

        private void StopAttack()
        {
            GetComponent<Animator>().ResetTrigger("attack");
            GetComponent<Animator>().SetTrigger("stopAttack");
        }
    }
}

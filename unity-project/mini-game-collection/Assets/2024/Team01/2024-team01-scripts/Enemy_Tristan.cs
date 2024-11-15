using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MiniGameCollection;


namespace MiniGameCollection.Games2024.Team01
{
    public class Enemy_Tristan : MonoBehaviour
    {
        public float health = 100f;
        public float enemyDamage = 1f;


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void TakeDamage(float amount)
        {
            health -= amount;
            if (health <= 0f)
            {
                Destroy(gameObject);
            }
        }

        public void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                var healthComponent = collision.gameObject.GetComponent<PlayerHealth>();
                if (healthComponent != null)
                {
                    healthComponent.PlayerTakeDamage(enemyDamage);
                }
                Destroy(gameObject);
            }
        }
    }

}

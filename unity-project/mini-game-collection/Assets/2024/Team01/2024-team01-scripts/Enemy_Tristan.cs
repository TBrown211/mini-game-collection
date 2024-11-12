using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MiniGameCollection;


namespace MiniGameCollection.Games2024.Team01
{
    public class Enemy_Tristan : MonoBehaviour
    {
        public float health;
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
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MiniGameCollection.Games2024.Team01
{
    public class PlayerHealth : MonoBehaviour
    {
        public float playerMaxHealth = 3f;
        public float playerCurretHealth;

        private void Start()
        {
            playerCurretHealth = playerMaxHealth;
        }

        public void TakeDamage(float amount)
        {
            playerCurretHealth -= amount;
            if (playerCurretHealth <= 0)
            {
                SceneManager.LoadScene("Tristan-Test");
            }
        }
    }

}

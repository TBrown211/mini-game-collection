using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MiniGameCollection;


namespace MiniGameCollection.Games2024.Team01
{
    public class TurretController : MonoBehaviour
    {
        public float sensitivity = 100f;

        public Transform rotateTurret;
        public Camera turretCam;

        float xRotation = 0f;
        [SerializeField]
        float gunRange = 200f;
        [SerializeField]
        float damage = 25f;
        

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            //Arcade Input
            float lookX = ArcadeInput.Player2.AxisX * sensitivity * Time.deltaTime;
            float lookY = ArcadeInput.Player2.AxisY * sensitivity * Time.deltaTime;
            //bool shoot = ArcadeInput.Player2.Action1.Down;

            if (ArcadeInput.Player2.Action1.Down) // Use the shoot function
            {
                Shoot();
            }

            //Camera Movement
            xRotation -= lookY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            rotateTurret.Rotate(Vector3.up * lookX);
        }

        public void Shoot()
        {
            RaycastHit hit;
            if (Physics.Raycast(turretCam.transform.position, turretCam.transform.forward, out hit, gunRange))
            {
                Debug.Log(hit.transform.name);

                Enemy_Tristan enemy = hit.transform.GetComponent<Enemy_Tristan>();
                if (enemy != null)
                {
                    enemy.TakeDamage(damage);
                }
            }
        }
    }
}


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

        float xRotation = 0f;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            float lookX = ArcadeInput.Player2.AxisX * sensitivity * Time.deltaTime;
            float lookY = ArcadeInput.Player2.AxisY * sensitivity * Time.deltaTime;

            xRotation -= lookY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            rotateTurret.Rotate(Vector3.up * lookX);

        }
    }
}


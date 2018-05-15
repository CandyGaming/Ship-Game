using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    Rigidbody ship;
    Transform shipTranform;
    public Transform RotaterCam;
    public float shipSpeed = 50000f;
    public float shipRotationRate = 1.2f;
    //2
    private void Start()
    {
        ship = GetComponent<Rigidbody>();
        shipTranform = GetComponent<Transform>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {

            shipTranform.Rotate(0, -shipRotationRate, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {

            shipTranform.Rotate(0, shipRotationRate, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            ship.AddForce(shipTranform.right * shipSpeed);

        }
        if (Input.GetKey(KeyCode.S))
        {

            ship.AddForce(shipTranform.right * -shipSpeed);

        }
        RotaterCam.Rotate(0, Input.GetAxis("Mouse X"), 0);
    }
}

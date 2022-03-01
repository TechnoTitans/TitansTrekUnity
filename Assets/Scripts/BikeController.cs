using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class BikeController : MonoBehaviour
{
    public float fuel = 1;
    public float fuelconsumption = 0.01f;
    public Rigidbody2D carRigidBody;
    public Rigidbody2D backTire;
    public Rigidbody2D frontTire;
    public Rigidbody2D midTire;
    public float speed = 20;
    public float carTorque = 10;
    private float movement;
    public UnityEngine.UI.Image image;
    public GameObject gameOverMenu;
    public GameObject helmet;

    public void Update()
    {
        movement = CrossPlatformInputManager.GetAxis("Horizontal");
        image.fillAmount = fuel;
    }

    private void FixedUpdate()
    {
        if(fuel>0)
        {
            backTire.AddTorque(-movement * speed / 5 * Time.fixedDeltaTime);
            frontTire.AddTorque(-movement * speed / 5 * Time.fixedDeltaTime);
            carRigidBody.AddTorque(movement * carTorque * Time.fixedDeltaTime);
        }

        fuel -= fuelconsumption * Mathf.Abs(-movement) * Time.fixedDeltaTime;

        if (fuel <= 0)
        {
            gameOverMenu.SetActive(true);
            Destroy(helmet);
        }
    }
}

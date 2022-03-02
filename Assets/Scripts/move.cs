using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
private float playerSpeed;
private Rigidbody2D rb;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerSpeed = 12f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0) {

            Touch touch = Input.GetTouch(0);

            switch (touch.phase) {
                case TouchPhase.Began:
                    if  (touch.position.y < Screen.height / 2)
                        rb.velocity = new Vector2(0f, - playerSpeed);
                    if (touch.position.y > Screen.height / 2)
                        rb.velocity = new Vector2(0f, playerSpeed);
                break;

                case TouchPhase.Ended:
                    rb.velocity = new Vector2(0f, 0f);
                break;
            }
        }
    }
}

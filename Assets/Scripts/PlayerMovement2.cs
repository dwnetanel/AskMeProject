using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    float mouseX = 50f; //Mouse Movement
    float x;
    float y;

    float Speed;
    float mSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Speed = 10f;
        mSpeed = 60f;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * mSpeed * Time.deltaTime; //Mouse Movement
        transform.Rotate(0, mouseX, 0); //Mouse Movement - Rotation

        x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime; //keyboard movement
        y = Input.GetAxis("Vertical") * Speed * Time.deltaTime; //keyboard movement
        transform.Translate(x, 0, y);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_touch : MonoBehaviour
{
    private void Start()
    {

    }

    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            // Move the cube if the screen has the finger moving.
            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 pos = touch.position;
                transform.localRotation = Quaternion.Euler(new Vector3(0.0f,-pos.x,0.0f));
                //Quaternion rotU = Quaternion.AngleAxis(10 * Time.deltaTime, Vector3.up);
                //transform.rotation = transform.rotation * rotU;
            }
        }
    }
}

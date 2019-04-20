using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;


    private void Update()
    {
        GetInputs();
    }

    private void GetInputs()
    {
        Vector2 tmpPos = transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            tmpPos.y += speed *Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            tmpPos.y -= speed * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.A))
        {
            tmpPos.x -= speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            tmpPos.x += speed * Time.deltaTime;
        }

        transform.position = tmpPos;

    }


}

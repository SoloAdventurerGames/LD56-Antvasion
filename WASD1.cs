using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD1 : MonoBehaviour
{
    public float speed;
    public float rotspeed;
    public float Bspeed;
    public float jump = 200f;

    public bool canfight = true;
    public bool back;

    Rigidbody rigi;


    // Update is called once per frame
    public void Start()
    {
        rigi = GetComponent<Rigidbody>();
        FindObjectOfType<AudioManager>().Play("Tank_Idle");
        
    }

   
    void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            FindObjectOfType<AudioManager>().Play("Tank_Moving");

        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            FindObjectOfType<AudioManager>().Stop("Tank_Moving");
        }

            if (Input.GetKeyDown(KeyCode.S))
            {
                FindObjectOfType<AudioManager>().Play("Tank_Moving_R");

            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                FindObjectOfType<AudioManager>().Stop("Tank_Moving_R");

            }

      


        
    if (Input.GetKey(KeyCode.W))
    {
    transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    if (Input.GetKey(KeyCode.S))
    {
    transform.Translate(-1 * Vector3.forward * Time.deltaTime * Bspeed);
    back = true;
    }
    else
    {
    back = false;
    }


    if (Input.GetKey(KeyCode.A))
    {
    transform.Rotate(Vector3.down * Time.deltaTime * rotspeed);
    }
    else if (Input.GetKey(KeyCode.A) && back == true)
    {
    transform.Rotate(Vector3.up * Time.deltaTime * Bspeed);
    }


    if (Input.GetKey(KeyCode.D))
    {
    transform.Rotate(Vector3.up * Time.deltaTime * rotspeed);
    }
    else if (Input.GetKey(KeyCode.D) && back == true)
    {
    transform.Rotate(Vector3.down * Time.deltaTime * Bspeed);
    }

        
        



                



    }
}

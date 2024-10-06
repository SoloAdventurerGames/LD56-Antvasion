using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour
{

   public float mousesens = 10f;
    public Transform player;
    

    public GameObject maincampos;
    public Camera main;

    public Transform Canon;


    public float zRotation = 0f;
    public float XRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;


    }

    // Update is called once per frame
    public void Update()
    {
        float mousex = Input.GetAxis("Mouse X");
        player.Rotate(Vector3.forward * mousex);



        /*
        float mousex = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y") * mousesens * Time.deltaTime;

        zRotation -= mousex;
        zRotation = Mathf.Clamp(zRotation, -90f, 90f);

        player.localRotation = Quaternion.Euler(0f, 0f, zRotation);
        player.Rotate(Vector3.left * mousex);
        */



    }
}

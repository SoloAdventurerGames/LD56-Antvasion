using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canonmove : MonoBehaviour
{
    public Transform player;
    float XRotation = 0f;
    float yRotation = 0f;
    public float mousesens = 10f;
    public GameObject maincampos;
    public Camera main;


    // Update is called once per frame
    void Update()
    {
          float mousex = Input.GetAxis("Mouse Y");
         player.Rotate(Vector3.down * mousex);


        /*float mousex = Input.GetAxis("Mouse X") * mousesens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mousesens * Time.deltaTime;

        XRotation -= mouseY;
        XRotation = Mathf.Clamp(XRotation, -5f, 10f);

        transform.localRotation = Quaternion.Euler(0f, XRotation, 0f);
        player.Rotate(Vector3.up * mousex);
        
      */
        
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject[] shots;
    public int selectedshot;
    public Transform barrelend;
    public bool shot;


    public void Update()
    {


        if (Input.GetButtonDown("Fire1") && shot == false)
        {
            Instantiate(shots[selectedshot], barrelend.position, barrelend.rotation);
            FindObjectOfType<AudioManager>().Play("Tank_Shot_1");
            shot = true;
            FindObjectOfType<AudioManager>().Play("Tank_Reload");
            StartCoroutine(Reload());
        }
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(3);
        shot = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public Rigidbody rigi;
    public float power;
    public SphereCollider shotheard;
    
    void Start()
    {
        rigi.AddForce(transform.forward * power);
        StartCoroutine(Destroyshot());
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            Debug.Log("Hit ground");
            shotheard.enabled = true;
            Destroy(this.gameObject);
        }

        if( collision.gameObject.CompareTag("body"))
        {
            Debug.Log("Hit body");
            shotheard.enabled = true;
            collision.gameObject.transform.parent.gameObject.GetComponent<Movement>().death();
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("head"))
        {
            Debug.Log("Hit head");
            shotheard.enabled = true;
            collision.gameObject.transform.parent.gameObject.GetComponent<Movement>().death();
            Destroy(this.gameObject);
        }

    }

    IEnumerator Destroyshot()
    {
        yield return new WaitForSeconds(10);
        Debug.Log("Hit void");
        Destroy(this.gameObject);
    }
}

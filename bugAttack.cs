using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bugAttack : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerStats>().health -= 1;
        }
    }
}

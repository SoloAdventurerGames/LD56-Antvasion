using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Alerted : MonoBehaviour
{
    public Movement move;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            move.alerted = true;
            this.enabled = false;
        }
        if (other.CompareTag("shot"))
        {
            move.alerted = true;
            this.enabled = false;
        }
    }
}

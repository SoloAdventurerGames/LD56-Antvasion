using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    public GameObject[] capcols;
    public GameObject[] patpoints;
    public int pointselected;
    public NavMeshAgent agent;
    public GameObject player;
    public Animator Anim;

    public bool alerted;
    public bool alertanim;
    public int range;

    public bool dead;
    public BoxCollider boxcol;
    public BoxCollider Attackcol;

    public Alerted alerted_S;

    WinLoss winloss;
    // Start is called before the first frame update
    void Start()
    {
        agent = this.gameObject.GetComponent<NavMeshAgent>();
        patpoints = GameObject.FindGameObjectsWithTag("Patpoint");
        pointselected = Random.Range(0, patpoints.Length);
        Anim = gameObject.GetComponent<Animator>();
        winloss = GameObject.Find("GameManager").GetComponent<WinLoss>();
        winloss.bugcounterNum += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (dead == false)
        {
            if (alerted == false)
            {
                agent.SetDestination(patpoints[pointselected].transform.position);
                agent.stoppingDistance = 0;
                if (this.gameObject.transform.position.x == patpoints[pointselected].transform.position.x)
                {
                    pointselected = Random.Range(0, patpoints.Length);
                }
            }
            else if (alerted == true)
            {
                agent.destination = player.transform.position;
                agent.speed = 8f;
                agent.stoppingDistance = 12;
                if (alertanim == false)
                {
                    Anim.SetBool("Alert", true);
                    StartCoroutine(endalert());
                    alertanim = true;
                }

            }

            if (agent.velocity.magnitude >= 0.1)
            {
                Anim.SetBool("IsWalking", true);
            }
            else if (agent.velocity.magnitude <= 0)
            {
                Anim.SetBool("IsWalking", false);
            }

            RaycastHit hit;
            if (Physics.Raycast(gameObject.transform.position, gameObject.transform.forward, out hit, range))
            {
                Debug.Log(hit.transform.name);

                if (hit.collider.CompareTag("Player"))
                {
                    alerted_S.enabled = false;
                    Anim.SetBool("attack", true);
                    agent.isStopped = true;
                    
                    
                }
                else
                {
                    Anim.SetBool("attack", false);
                    agent.isStopped = false;
                    alerted_S.enabled = true;

                }
            }
        }
    }

   

    public void death()
    {
        foreach (GameObject C in capcols)
        {
            C.gameObject.SetActive(false);
        }
        Anim.SetBool("dead", true);
        agent.isStopped = true;
        dead = true;
        Attackcol.enabled = false;
        Rigidbody rigi = gameObject.GetComponent<Rigidbody>();
        rigi.useGravity = true;
        agent.enabled = false;
        boxcol.enabled = true;
        winloss.bugcounterNum -= 1;
        

    }
    IEnumerator endalert()
    {
        yield return new WaitForSeconds(2);
        
            Anim.SetBool("Alert", false);
    }
}

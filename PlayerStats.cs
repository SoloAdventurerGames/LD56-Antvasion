using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public int health;
    public bool death;
    public bool deathsound;

    public WASD turret;
    public WASD1 Movement;
    public Shooting shoot;
    public Rigidbody rigi;

    public TextMeshProUGUI deathtext;
    public string[] deathtype;
    public int typenum;
    public bool typedone;

    public Image fade;
    public float fadegrade;

    public GameObject menu;
    public WinLoss win;
    public void Update()
    {
        if (health <= 0 && death == false)
        {
            health = 0;
     
            deathsound = true;
           
            Movement.enabled = false;
            shoot.enabled = false;
            turret.enabled = false;
            
            
            FindObjectOfType<AudioManager>().Stop("Tank_Moving");
            FindObjectOfType<AudioManager>().Stop("Tank_Idle");

            fade.enabled = true;
            StartCoroutine(Typewriter1());
            StartCoroutine(Menu());
            death = true;

        }

        if (deathsound == true)
        {
            deathsfx();
            
        }
    }

    
    public void deathsfx()
    {
       
            FindObjectOfType<AudioManager>().Play("Tank_Death");
            deathsound = false;
        
    }
    IEnumerator Typewriter1()
    {
        if (typedone == false)
        {
            yield return new WaitForSeconds(.05f);
            deathtext.text = deathtype[typenum];
            typenum += 1;
            fadegrade += .1f * Time.deltaTime * 3;
            fade.color = new Color(fade.color.r, fade.color.g, fade.color.b, fadegrade);
            StartCoroutine(Typewriter1());
            if (deathtext.text == deathtype[20])
            {
                typedone = true;
            }
        }

    }

    IEnumerator Menu()
    {
        yield return new WaitForSeconds(3);
        menu.SetActive(true);
    }

    public IEnumerator reloadlevel()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(win.loadscene);
    }

}



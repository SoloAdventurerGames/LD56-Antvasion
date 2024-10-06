using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour
{
    public PlayerStats Player;

    private void Start()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player.health = 0;
            Player.rigi.drag = 100;
            Player.fadegrade += .1f * Time.deltaTime * 10;
            Player.fade.color = new Color(Player.fade.color.r, Player.fade.color.g, Player.fade.color.b, Player.fadegrade);
            StartCoroutine(Player.reloadlevel());

        }
    }
}

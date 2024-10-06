using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WinLoss : MonoBehaviour
{
    public int Level;
    public int loadscene;
  
    
    public TextMeshProUGUI bugcounterText;
    public TextMeshProUGUI LevelcompleteText;
    public int bugcounterNum;
    public string[] levelcomplete;
    public int typenum;
    public bool typedone;
    SaveData saveData;

    public GameObject menu;
    public WASD wasd;
    public WASD1 wasd1;
    

    void Start()
    {
        saveData = GameObject.Find("Save Manager").GetComponent<SaveData>();
        saveData.Levelcomplete = 0;
    }

    // Update is called once per frame
    void Update()
    {
        bugcounterText.text = "Bugs to exterminate" + " " + bugcounterNum.ToString();

        if(bugcounterNum <= 0)
        {
            StartCoroutine(Typewriter1());

            saveData.levelnum = Level;
            
            saveData.Levelcomplete = 1;
            saveData.SaveState();

        }
    }


    IEnumerator Typewriter1()
    {
        if (typedone == false)
        {
            yield return new WaitForSeconds(2);
            LevelcompleteText.text = levelcomplete[typenum];
            typenum += 1;
            menu.SetActive(true);
            wasd.enabled = false;
            wasd1.enabled = false;
            Cursor.lockState = CursorLockMode.Confined;
            if (LevelcompleteText.text == levelcomplete[13])
            {
                typedone = true;
                typenum = 13;
            }
        }

    }

   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class MainMenu : MonoBehaviour
{
    public GameObject MainMenu_P;
    public GameObject Level_Select_P;
    public GameObject Confirm_Overwrite_P;
    public Button delete;
    public int Level;
    public SaveData saveData;


    public void Update()
    {
        if (saveData.Levelcomplete == 1)
        {
            delete.interactable = true;
        }
        else
        {
            delete.interactable = false;
        }
    }
    public void quit()
    {
        Application.Quit();
    }

    public void Retry()
    {
        SceneManager.LoadScene(Level);
    }

    public void levelselect()
    {
        Level_Select_P.SetActive(true);
        MainMenu_P.SetActive(false);
    }

    public void MainReturn()
    {
        MainMenu_P.SetActive(true);
        Level_Select_P.SetActive(false);
        Confirm_Overwrite_P.SetActive(false);
    }

    public void overwriteconfirm()
    {
        Confirm_Overwrite_P.SetActive(true);
        MainMenu_P.SetActive(false);
    }

    public void overwrite()
    {
        
        saveData.ClearData();
        MainMenu_P.SetActive(true);
        Level_Select_P.SetActive(false);
    }
}

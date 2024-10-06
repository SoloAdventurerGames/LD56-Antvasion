using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;


public class SaveData : MonoBehaviour
{
    public int Levelcomplete;
    public string[] level;
    public int levelnum;


    public int level1;
    public int level2;
    public int level3;

    public void Start()
    {
        LoadData();
    }
    private void Update()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void LoadData()
    {
        foreach (string L in level)
        {
            Levelcomplete = PlayerPrefs.GetInt(L);
        }
        level1 = PlayerPrefs.GetInt("Level_1");
        level2 = PlayerPrefs.GetInt("Level_2");
        level3 = PlayerPrefs.GetInt("Level_3");
    }

    public void SaveState()
    {
        PlayerPrefs.SetInt(level[levelnum], Levelcomplete) ;
    }

    public void ClearData()
    {
        Levelcomplete = 0;
        PlayerPrefs.DeleteAll();
    }
}


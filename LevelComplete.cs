using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelComplete : MonoBehaviour
{
    public SaveData save;
    
    public Image checkmark1;
    public Image checkmark2;
    public Image checkmark3;

    public bool level1;
    public bool level2;
    public bool level3;
    // Update is called once per frame
    void Update()
    {
        if (level1 == true)
        {
            if (save.level1 == 1)
            {
                checkmark1.enabled = true;
            }
            else if (save.level1 == 0)
            {
                checkmark1.enabled = false;
            }
        }
        if (level2 == true)
        {
            if (save.level2 == 1)
            {
                checkmark2.enabled = true;
            }
            else if (save.level2 == 0)
            {
                checkmark2.enabled = false;
            }
        }
        if (level3 == true)
        {
            if (save.level3 == 1)
            {
                checkmark3.enabled = true;
            }
            else if (save.level3 == 0)
            {
                checkmark3.enabled = false;
            }
        }
    }
}

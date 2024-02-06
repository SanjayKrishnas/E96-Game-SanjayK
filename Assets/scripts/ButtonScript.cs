using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public void onPressed()
    {
        /*
        Image image = GetComponent<Image>();
        image.color = Color.blue;
        */

        if(Time.timeScale == 1)
        {
            Time.timeScale = 0; //pause
        }
        else
        {
            Time.timeScale = 1; //unpause
        }
    }
}

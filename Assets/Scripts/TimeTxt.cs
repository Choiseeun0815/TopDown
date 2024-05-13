using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeTxt : MonoBehaviour
{
    public Text time;
  
    private void Update()
    {
        GetCurrentTime();

    }
    private void GetCurrentTime()
    {
        string currentTime = DateTime.Now.ToString("HH:mm");
        time.text = currentTime;
    }

   
}

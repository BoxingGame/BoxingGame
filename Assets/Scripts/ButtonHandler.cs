﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonHandler : MonoBehaviour
{
    public void Retry(){
        SceneManager.LoadScene("Menu");
    }
    public void Quit(){
        Application.Quit();
    }
    
}

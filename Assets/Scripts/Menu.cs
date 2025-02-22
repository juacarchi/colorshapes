﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    string url = "https://iquick.es";
    public void Play(int sceneIndex)
    {
        ManagerScene.instance.SetNumberSceneToChange(sceneIndex);
        TransitionManager.instance.AnimateTransition();
       
    }
    public void Levels(int sceneIndex)
    {
        ManagerScene.instance.SetNumberSceneToChange(sceneIndex);
        TransitionManager.instance.AnimateTransition();
        
    }
    public void PlayButton()
    {
        SoundManager.instance.PlaySFX(SoundManager.instance.buttonSound);
        
    }
    public void Exit()
    {
        //WEBGL
        Application.OpenURL(url);
        //ANDROID
        //Application.Quit();
        
    }
}

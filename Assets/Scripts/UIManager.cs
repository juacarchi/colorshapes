﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button pauseButton;
    public Text textPuntuacion;
    public Text numberForma;
    public Canvas canvasPause;
    public GameObject canvasVictory;
    Animator animVictory;
    public static UIManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            
        }
        else
        {
            Destroy(this.gameObject);
        }
        canvasPause.enabled = false;
        canvasVictory.SetActive(false);
        animVictory=canvasVictory.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        textPuntuacion.text = GameManager.instance.GetRecollectedFormas().ToString();
        numberForma.text = GameManager.instance.GetNumberForma().ToString();
    }
    public void OpenPause()
    {
        canvasPause.enabled = true;
    }
    public void ClosePause()
    {
        canvasPause.enabled = false;
        
    }
    public void Victory()
    {
        canvasVictory.SetActive(true);
        pauseButton.interactable = false;
        GameManager.instance.SetLevelComplete(true);
    }
    

}

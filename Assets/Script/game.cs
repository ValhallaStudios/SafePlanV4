﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class game : MonoBehaviour {
    public int timer;
    public AudioSource ambiente;
    public Text txtTimer;
    public GameObject loadScene;
	// Use this for initialization
	void Start () {
        txtTimer.text = timer.ToString();
        StartCoroutine(cronometro(timer));
        DontDestroyOnLoad(ambiente.gameObject);
        loadScene = GameObject.FindGameObjectWithTag("load");
        Destroy(loadScene);

    }
	
	// Update is called once per frame
	void Update () {
		
	}


    IEnumerator cronometro(int _timer)
    {
        
        txtTimer.text = timer.ToString();
        timer--;
        yield return new WaitForSeconds(1.0f);
        StartCoroutine(cronometro(timer));
        if (timer == 0)
        {
            Application.LoadLevel("Quiz");
            StopCoroutine(cronometro(timer));
        }
    }
    public void Quiz() {
        Application.LoadLevel("Quiz");
    }
    public void Quiz2()
    {
        Application.LoadLevel("Quiz 2");
    }
}

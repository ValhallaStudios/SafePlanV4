using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SceneManager : MonoBehaviour {

    public Animator anima;
    public string name;
    public GameObject target;
    public Text txtTimer;
    public  int timer;

    // Use this for initialization
    void Start () {
       name = target.tag.ToString();
       
       
	}
	
	// Update is called once per frame
	void Update () {
        txtTimer.text = timer.ToString();
    }

    public void chamarAnim() {
        StartCoroutine("Anim");
    }

    public void BackMenu() {
        Application.LoadLevel("menu");
    }

    public void BackGameMode()
    {
        Application.LoadLevel("GameMode");
    }
    IEnumerator Anim()
    {
        anima.SetBool("fade", true);
        
        yield return new WaitForSeconds(0.45f);
        
        Application.LoadLevel(name);

        yield return new WaitForSeconds(1.0f);
        StartCoroutine(cronometro(timer));

    }

    IEnumerator cronometro(int _timer) {
        timer--;
        yield return new WaitForSeconds(_timer);
        StartCoroutine(cronometro(timer));
    }

    
    }

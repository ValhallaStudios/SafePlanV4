using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game : MonoBehaviour {
    public int timer;
    public Text txtTimer;
	// Use this for initialization
	void Start () {
        txtTimer.text = timer.ToString();
        StartCoroutine(cronometro(timer));
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    IEnumerator cronometro(int _timer)
    {
        
        txtTimer.text = timer.ToString();
        timer--;
        print("teste");
        yield return new WaitForSeconds(1.0f);
        StartCoroutine(cronometro(timer));
    }
}

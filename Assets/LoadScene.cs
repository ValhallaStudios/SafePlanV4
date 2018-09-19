using System;
using System.Collections;
using Random = UnityEngine.Random;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour {
    public GameObject[] UI;
	// Use this for initialization
	void Start () {
        StartCoroutine(loadScene());
	}

   

    // Update is called once per frame
    void Update () {
	}

    IEnumerator loadScene() {
        yield return new WaitForSeconds(10.0f);
        int index = Random.Range(0, UI.Length);
        UI[index].SetActive(true);
        DontDestroyOnLoad(UI[index]);
        Application.LoadLevel("Game");
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacaoCena : MonoBehaviour {
	public GameObject cenaAnimada;
	public GameObject cenaFinal;
    public GameObject tela;
	// Use this for initialization
	void Start () {
        StartCoroutine(animacao());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	 IEnumerator animacao (){
		yield return new WaitForSeconds(5.0f);
        tela.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        cenaAnimada.SetActive(false);
        cenaFinal.SetActive(true);
	}
}

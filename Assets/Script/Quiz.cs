
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour {
    public List<string> alternativas;
    public List<Text> alternativasTexto;
    int limite = 5;
   
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        SortearAlternativas();
        
    }


    void SortearAlternativas() {
        foreach (var alt in alternativas)
        {
            int index = UnityEngine.Random.Range(0, limite);
             alternativasTexto[index].text = alt.ToString();
            alternativasTexto.RemoveAt(index);
            limite--;
            alternativas.Remove(alt);
        }
        if (alternativas.Count <=0)
        {
            
            RespostaCerta();
        }
    }

    private void RespostaCerta()
    {
        //Achar a alternativa Correta via tag com id da pergunta
    }
}

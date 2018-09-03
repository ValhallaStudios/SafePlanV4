
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour {
    public List<string> alternativas;
    public List<Text> alternativasTexto;
    public List<Text> listaAcharRespostaCerta;
    public bool Acerto;
    public string Resposta;
    public selecionar selecionarScript;
    int limite = 5;
    public GameObject pergunta;
    public Button btnVerificar;
   
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
        if (alternativas.Count <= 0 && alternativasTexto.Count <= 0)
        {
            AcharResposta();
        }
    }
    void AcharResposta() {
        if (listaAcharRespostaCerta[0].text == Resposta && selecionarScript.botoes[1] )
        {
            print("REPOSTA CERTA!! PARABENS");
            Acerto = true;
        }
        else if (listaAcharRespostaCerta[1].text == Resposta && selecionarScript.botoes[2])
        {
            print("REPOSTA CERTA!! PARABENS");
            Acerto = true;
        }
        else if (listaAcharRespostaCerta[2].text == Resposta && selecionarScript.botoes[3])
        {
            print("REPOSTA CERTA!! PARABENS");
            Acerto = true;
        }
        else if (listaAcharRespostaCerta[3].text == Resposta && selecionarScript.botoes[4])
        {
            print("REPOSTA CERTA!! PARABENS");
            Acerto = true;
        }
        



    }
    public void Acertou() {
        if (Acerto)
        {
            Application.LoadLevel("Fase2");
        }
        else
        {
            print("Resposta Errada");
        }
    }
   

   
}

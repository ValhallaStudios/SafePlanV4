
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
    public GameObject AcertouTitle;
    public GameObject ErrouTitle;
    public GameObject telaPreta;
    public GameObject timer;
    public selecionar selecionarScript;
    int limite = 5;
    public GameObject pergunta;
    public GameObject somAmbiente;
    public Button btnVerificar;
   
	// Use this for initialization
	void Start () {
        somAmbiente = GameObject.FindGameObjectWithTag("ambiente");
        somAmbiente.GetComponent<AudioSource>().volume = 1.0f ;
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
    bool AcharResposta() {
        if (listaAcharRespostaCerta[0].text == Resposta && selecionarScript.botoes[0] )
        {
            print("REPOSTA CERTA!! PARABENS");
            return true;
        }
        else if (listaAcharRespostaCerta[1].text == Resposta && selecionarScript.botoes[1])
        {
            print("REPOSTA CERTA!! PARABENS");
            return true;
        }
        else if (listaAcharRespostaCerta[2].text == Resposta && selecionarScript.botoes[2])
        {
            print("REPOSTA CERTA!! PARABENS");
            return true;
        }
        else if (listaAcharRespostaCerta[3].text == Resposta && selecionarScript.botoes[3])
        {
            print("REPOSTA CERTA!! PARABENS");
            return true;
        }
        return false;




    }
    public void Mensagem() {
        if (AcharResposta())
        {
            DontDestroyOnLoad(somAmbiente);
            telaPreta.SetActive(true);
            AcertouTitle.SetActive(true);
            Destroy(timer);

        }
        else
        {
            telaPreta.SetActive(true);
            ErrouTitle.SetActive(true);
            Destroy(timer);
        }
    }
    public void Acertou() {
        if (AcharResposta())
        {
            Application.LoadLevel("Fase2");
        }
        else
        {
            print("Resposta Errada");
        }
    }
   

   
}

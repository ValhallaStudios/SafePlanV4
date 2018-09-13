using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selecionar : MonoBehaviour {
    public Image[] img;
    public bool[] botoes;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void Botao1(){
        if (!img[0].enabled)
        {
            img[0].enabled = true;
            img[1].enabled = false;
            img[2].enabled = false;
            img[3].enabled = false;
            botoes[0] = true;
            botoes[3] = false;
            botoes[2] = false;
            botoes[1] = false;

        }
       
        
       
	}
    public void Botao2()
    {
        if (!img[1].enabled)
        {
            img[1].enabled = true;
            img[0].enabled = false;
            img[2].enabled = false;
            img[3].enabled = false;
            botoes[1] = true;
            botoes[3] = false;
            botoes[2] = false;
            botoes[0] = false;

        }
       
        

    }
    public void Botao3()
    {
        if (!img[2].enabled)
        {
            img[2].enabled = true;
            img[0].enabled = false;
            img[1].enabled = false;
            img[3].enabled = false;
            botoes[2] = true;
            botoes[3] = false;
            botoes[1] = false;
            botoes[0] = false;

        }
        

    }
    public void Botao4()
    {
        if (!img[3].enabled)
        {
            img[3].enabled = true;
            img[0].enabled = false;
            img[1].enabled = false;
            img[2].enabled = false;
            botoes[3] = true;
            botoes[2] = false;
            botoes[1] = false;
            botoes[0] = false;

        }
      

    }
}

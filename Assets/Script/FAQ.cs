using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FAQ : MonoBehaviour {

    public GameObject Texto;
    public GameObject Texto2;


    public void Escrever() {
        Texto.SetActive(true);
        Texto2.SetActive(false);
    }
    public void Escrever2()
    {
        Texto.SetActive(false);
        Texto2.SetActive(true);
    }

}

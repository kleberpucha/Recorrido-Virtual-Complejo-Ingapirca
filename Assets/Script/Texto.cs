using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texto : MonoBehaviour
{
    public string español;
    public string ingles;
    public string quechua;
    public bool esBoton;
    public Toggle toggleEspañol;
    public Toggle toggleIngles;
    public Toggle toggleQuechua;

    public IdiomaGlobal idiomaGlobal;

    // Start is called before the first frame update
    void Start()
    {
        NotificationCenter.DefaultCenter().AddObserver(this,"CambiarIdioma_");
        CambiarIdioma_();
    }
    void Awake()
    {
        idiomaGlobal = GameObject.Find("Scripts").GetComponent<IdiomaGlobal>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void CambiarIdioma_() {
        if (idiomaGlobal.RetornoIdioma()=="Español")
        {
            if (esBoton)
            {
                GetComponentInChildren<Text>().text = español;
            }
            else
            {
                GetComponent<Text>().text = español;
            }
        }
        if (idiomaGlobal.RetornoIdioma() == "Ingles")
        {
            if (esBoton)
            {
                GetComponentInChildren<Text>().text = ingles;
            }
            else
            {
                GetComponent<Text>().text = ingles;
            }
        }
        if (idiomaGlobal.RetornoIdioma() == "Quechua")
        {
            if (esBoton)
            {
                GetComponentInChildren<Text>().text = quechua;
            }
            else
            {
                GetComponent<Text>().text = quechua;
            }
        }

    }
}

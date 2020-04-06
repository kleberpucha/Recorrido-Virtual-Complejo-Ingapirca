using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdiomaGlobal : MonoBehaviour
    
{
    public static string IdiomaActual = "Español";
    public Toggle toggleEspañol;
    public Toggle toggleIngles;
    public Toggle toggleQuechua;
    public bool EsEscenaMenu = true;

    void Awake()
    {
        //DontDestroyOnLoad(transform.gameObject);   
    }
    public string RetornoIdioma() {
        return (IdiomaActual);
    }
    void Start()
    {
        CambiarIdioma(IdiomaActual);    
    }
    public void CambiarIdioma(string idioma)
    {
        IdiomaActual = idioma;
        NotificationCenter.DefaultCenter().PostNotification(this, "CambiarIdioma_", idioma);
       if (EsEscenaMenu)
       { 
        if (idioma == "Español")
        {
            toggleEspañol.isOn = true;
        } else if (idioma == "Ingles")
        {
            toggleIngles.isOn = true;
        } else if (idioma == "Quechua") {
            toggleQuechua.isOn = true;
        }
       }
    }
}

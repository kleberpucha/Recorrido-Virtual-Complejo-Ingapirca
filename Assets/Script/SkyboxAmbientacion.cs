using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class SkyboxAmbientacion : MonoBehaviour
{
    public Material[] skybox;

    // Start is called before the first frame update
    void Start()
    {

        string horastring = DateTime.Now.Hour.ToString();
        int horaint = int.Parse(horastring);
        RenderSettings.skybox = skybox[horaint];
    }

    // Update is called once per frame
    void Update()
    {
        DateTime fecha = DateTime.Now;
        print(fecha);
       
    }
}

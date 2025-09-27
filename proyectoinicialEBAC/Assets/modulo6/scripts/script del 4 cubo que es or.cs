using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Go4 : MonoBehaviour
{
    public GameObject capsule;
    public GameObject cube;
    bool esActivo;
    public Color colorVerdadero = Color.white;
    public Color colorFalso = Color.black;
    private Renderer objectRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        objectRenderer = GetComponent<Renderer>();
    }

    void FixedUpdate()
    {


        if (capsule.GetComponent<vairablecomoverdadera>().esActivo || cube.GetComponent<colorChanger>().isTrue)
        {
            objectRenderer.material.color = colorVerdadero;
            esActivo = true;
        }
        else
        {
            objectRenderer.material.color = colorFalso;
            esActivo = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

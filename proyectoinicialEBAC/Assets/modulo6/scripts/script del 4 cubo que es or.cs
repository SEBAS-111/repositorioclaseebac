using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Go4 : MonoBehaviour
{
    public GameObject capsule;
    public GameObject cube;
    bool esActivo;
    bool isTrue;
    public Color colorVerdadero = Color.white;
    public Color colorFalso = Color.black;
    public bool resultados = false;
 
    private Renderer objectRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(capsule.GetComponent<vairablecomoverdadera>().esActivo);
        Debug.Log(cube.GetComponent<colorChanger>().isTrue);

        esActivo = true;
        isTrue = false;

        if (esActivo || isTrue)
        {
            Debug.Log("la operacion dio resultado verdadero");
        }
        else
        {
            Debug.Log("la operacion dio como resultado falso");
        }

        objectRenderer = GetComponent<Renderer>();
    }

    void FixedUpdate()
    {

        if (esActivo || isTrue)
        {
            objectRenderer.material.color = colorVerdadero;
        }
        else
        {
            objectRenderer.material.color = colorFalso;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static implicit operator Go4(bool v)
    {
        throw new NotImplementedException();
    }
}

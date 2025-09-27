using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripdel5cubo : MonoBehaviour
{
    public GameObject sphere;
    public GameObject cube2;
    public Color colorVerdadero = Color.white;
    public Color colorFalso = Color.black;
    bool isTrue;
    private Renderer objectRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        objectRenderer = GetComponent<Renderer>();


    }
    void FixedUpdate()
    {

        if (sphere.GetComponent<Go3>() && cube2.GetComponent<Go4>())
        { 
            objectRenderer.material.color = colorVerdadero;
            isTrue = true;
        
        }
        else
        {
            objectRenderer.material.color = colorFalso;
            isTrue = false;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}

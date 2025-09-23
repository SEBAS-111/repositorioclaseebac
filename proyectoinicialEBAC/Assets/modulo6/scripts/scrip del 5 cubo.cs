using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripdel5cubo : MonoBehaviour
{
    public GameObject sphere;
    public GameObject cube2;
    public Color colorVerdadero = Color.white;
    public Color colorFalso = Color.black;
    private bool resultado;
    private bool resultados;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        Debug.Log(sphere.GetComponent<Go3>().resultado);
        Debug.Log (cube2.GetComponent<Go4>().resultados);

        resultado = true;
        resultados = false;

        if (resultado || resultados)
        {
            Debug.Log("la operacion dio verdadero");
        }
        else
        {
            Debug.Log("la operacion dio como falso");
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}

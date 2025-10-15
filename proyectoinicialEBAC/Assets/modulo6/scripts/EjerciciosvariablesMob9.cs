using NUnit.Framework.Constraints;
using System;
using UnityEngine;

public class EjerciciosvariablesMob8 : MonoBehaviour
{
    short mishort = 0;
    int miint = 0;
    private Renderer objectRenderer;
    public Color coloresPar = Color.white;
    public Color coloresNon = Color.black;
    private int i;
    private int e;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float a, b;
        float f;
        a = 10;
        b = 5;
        f = a + b;
        Debug.Log("el valor de f es:" + f);

        objectRenderer = GetComponent<Renderer>();

        float miFlotante = 3.14159265f;
        string modificado = miFlotante.ToString("f4");
        Debug.Log("el numero flotante original es:" + miFlotante);
        Debug.Log("el numero modificado es:" + modificado);

        string miNombre = "Gonzalo Sebastian";
        string misApellidos = "Sanchez Morales";
        string primerNombre = miNombre.Substring(0, 7);
        string segundiNombre = miNombre.Substring(8);
        string primerApellido = misApellidos.Substring(0, 7);
        string segundoApellido = misApellidos.Substring(8);
        string salida = $"mi nombre es: {miNombre} y mis apellidos son {misApellidos}";
        Debug.Log(salida);
        Debug.Log(primerNombre);
        Debug.Log(segundiNombre);
        Debug.Log(primerApellido);
        Debug.Log(segundoApellido);

        int miEntero = 10;
        float miDecimal = 3.14f;
        double miDoble = 2.71828;
        Debug.Log("mi entero es:" + miEntero);
        Debug.Log("mi decimal es:" + miDecimal);
        Debug.Log("mi doble es" + miDoble);


        char miCaracter;
        string mistringdehola = "Hola Mundo";
        miCaracter = mistringdehola[0];
        miCaracter = mistringdehola[2];
        miCaracter = mistringdehola[6];
        miCaracter = mistringdehola[8];
        Debug.Log(miCaracter);
        

        string miPalabra = "Esta es oracion de ejemplo del mod8";
        string palabra1 = miPalabra.Substring(5);
        Debug.Log(palabra1);

    }

    // Update is called once per frame
    void Update()
    {
        mishort += 3;
        Debug.Log(mishort);

    }
    void FixedUpdate()
    {
        float f;
        f = 1;
        f *= 2;


        int e, i;
        e = 10;
        i = 5;
        miint = UnityEngine.Random.Range(e, i);
        if (miint % 2 == 0)
        {
            Debug.Log("el numero " + miint + "es Par");
            objectRenderer.material.color = coloresPar;
        }
        else
        {
            Debug.Log("el numero " + miint + "es non");
            objectRenderer.material.color = coloresNon;
        }

        string valorEntero = "1";
        switch (valorEntero)
        {
            case "1":
                Color colorespar1 = coloresPar;
                break;
            case "2":
                Color coloresNon1 = coloresNon;
                break;
        }

    }
}

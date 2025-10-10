using System.Drawing;
using UnityEngine;
using Color = UnityEngine.Color;

public class EjerciciosvariablesMob8 : MonoBehaviour
{
    short mishort = 0;
    int miint = 0;
    private Renderer objectRenderer;
    public Color coloresPar = Color.white;
    public Color coloresNon = Color.black;
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
        miint = Random.Range(e, i);
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


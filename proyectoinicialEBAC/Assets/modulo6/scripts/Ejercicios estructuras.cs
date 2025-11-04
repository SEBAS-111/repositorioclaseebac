using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Ejerciciosestructuras : MonoBehaviour
{
    public List<int> MiFuncion(int tamaño, int rangoinferior, int rangosuperior)
    {
        List<int> listaNumeros = new List<int>();

        if (rangoinferior > rangosuperior)
        {
            int temp = rangoinferior;
            rangoinferior = rangosuperior;
            rangosuperior = temp;
        }
        for (int i = 0;i < tamaño; i++)
        {
            int numeroAleatorio = UnityEngine.Random.Range(rangoinferior, rangosuperior + 1);

            listaNumeros.Add(numeroAleatorio);
        }
        return listaNumeros;
    }

    public int[] OrdenarDescendente(int[] arregloEntrada)
    {
        int[] arregloOredenado = (int[]) arregloEntrada.Clone();
        System.Array.Sort(arregloOredenado);
        System.Array.Reverse(arregloOredenado);
        return arregloOredenado;
    }

    Stack<string> pilaNombre = new Stack<string>();
    Queue<string> colaNombre = new Queue<string>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        List<int> milistadenumeros = MiFuncion(10, 1, 50);

        Debug.Log("lista generada con" + milistadenumeros.Count + "numeros");
        foreach (int i in milistadenumeros)
        {
            Debug.Log(i);
        }

        int[] miArreglo = { 5, 2, 8, 1, 9, 4 };
        int[] arregloDescendente = OrdenarDescendente(miArreglo);

        Debug.Log("Arreglo original:" + string.Join(", ", miArreglo));
        Debug.Log("Arreglo descendente" + string.Join(", ", arregloDescendente));

        pilaNombre.Push("Carlos");
        pilaNombre.Push("Ana");
        pilaNombre.Push("Luis");

        while (pilaNombre.Count > 0)
        {
            string nombre = pilaNombre.Pop();
            colaNombre.Enqueue(nombre);
        }
        foreach (string nombre in colaNombre)
        {
            Debug.Log(nombre);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

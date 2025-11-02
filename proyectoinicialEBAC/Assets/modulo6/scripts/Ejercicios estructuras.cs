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

    public HashSet<T> EliminarDuplicadosLinq<T>(List<T> listaConDuplicados)
    {
        HashSet<T> HashSetSinDuplicados = listaConDuplicados.Distinct().ToHashSet();
        return HashSetSinDuplicados;
    }

    Queue<string> colaStrings = new Queue<string>();
    Stack<string> pilaString = new Stack<string>();
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

        List<string> stringsRepetidos = new List<string> { "manzana", "pera", "pera", "banana", "manzana" };
        HashSet<string> stringsUnicos = EliminarDuplicadosLinq(stringsRepetidos);

        Debug.Log("lista original con Strings repetidos:" + string.Join(",", stringsRepetidos));
        Debug.Log("HashSet resultante con Strings unicos:" + string.Join(",", stringsUnicos));


        colaStrings.Enqueue("proyectiles 1");
        colaStrings.Enqueue("proyectiles 2");
        colaStrings.Enqueue("proyectiles 3");
        colaStrings.Enqueue("proyectiles 4");
        colaStrings.Enqueue("proyectiles 5");
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());


        pilaString.Push("As");
        pilaString.Push("cincoEspadas");
        pilaString.Push("tresCorazones");
        pilaString.Push("CuatroTreboles");
        pilaString.Push("ReyEspadas");
        Debug.Log(pilaString.Peek());
        pilaString.Pop();
        Debug.Log(pilaString.Peek());
        pilaString.Pop();
        Debug.Log(pilaString.Peek());
        pilaString.Pop();
        Debug.Log(pilaString.Peek());
        pilaString.Pop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

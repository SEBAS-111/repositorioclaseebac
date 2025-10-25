using UnityEngine;

public class EjerciciosdeCiclosyarreglos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int tamaño = 10;

        int[] arr1 = new int[tamaño];
        int[] arr2 = new int[tamaño];
        int[] arr3 = new int[tamaño];

        for (int i = 0; i < tamaño; i++)
        {
            arr1[i] = Random.Range(1, 101);
            arr2[i] = Random.Range(1, 101);
            arr3[i] = Random.Range(1, 101);
        }

        for (int i = 0; i < tamaño; i++)
        {
            Debug.Log($"arr1[{1}] = {arr1[i]}, arr2[{i}] = {arr2[i]}, arr3[{i}] = {arr3[i]}");
        }


        string[] palabras = new string[] { "Hola", "a", "todos", "en", "Unity" };
        string oracionCompleta = "";
        foreach (string palabra in palabras)
        {
            oracionCompleta += palabra + "";
        }
        Debug.Log(oracionCompleta);

        int[,] miMatriz = new int[,]
        {
            {1, 2, 3 },
            {4, 5, 6 }
        };
        int[] miVector = new int[] { 7, 8, 9 };
        int[] resultado = new int[2];
        for (int i = 0; i < miMatriz.GetLength(0); i++)
        {
            for(int j = 0; j < miMatriz.GetLength(1); j++)
            {
                resultado[1] += miMatriz[i, j] * miVector[j];
            }
        }

        for(int i = 0;i < resultado.Length;i++)
        {
            Debug.Log("resultado["+i+"]:" + resultado[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

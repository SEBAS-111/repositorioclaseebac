using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holamundo : MonoBehaviour
{
    int x;
    //started is called before the first frame updte
    void Start()
    {
        x = 0;
        print("algo paso");
        
        Debug.LogWarning("Algo salio medianamente mal");
        Debug.LogError("Algo salio muy mal");
    }

    //update is called once per frame
    void Update()
    {
        //x = x + 1;
        //Debug.Log(x);

        Debug.Log("hola desde Update");
    }
    private void FixedUpdate()
    {
        Debug.LogWarning("hola desde fixed update cada 50 frames");
    }

    private void LateUpdate()
    {
        Debug.Log("hola desde Late Update");
    }

    private void OnEnable()
    {
        Debug.LogWarning("el objeto ha sido habilitado");
    }

    private void OnDisable()
    {
        Debug.LogWarning("el objeto ha sido inhabilitado");
    }

}
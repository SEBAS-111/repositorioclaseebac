using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holamundo : MonoBehaviour
{
    //started is called before the first frame updte
    void Start()
    {
        print("algo paso");
        Debug.Log("Algo paso");
        Debug.LogWarning("Algo salio medianamente mal");
        Debug.LogError("Algo salio muy mal");
    }

    //update is called once per frame
    void Update()
    {

    }
}
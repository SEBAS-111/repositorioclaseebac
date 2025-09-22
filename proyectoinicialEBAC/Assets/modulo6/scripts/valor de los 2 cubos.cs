using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class valordelos2cubos : MonoBehaviour
{
    public GameObject capsule;
    public GameObject cube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(capsule.GetComponent<vairablecomoverdadera>().esActivo);
        Debug.Log(cube.GetComponent<colorChanger>().isTrue);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

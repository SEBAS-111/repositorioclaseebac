using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class componentes2 : MonoBehaviour 
{
    private void Awake()
    {
        
    }
    //started is called before the first frame updte
    void Start()
    {
        Debug.Log(componentes1.miObjeto.name);
    }

    //update is called once per frame
    void Update()
    {

    }
}

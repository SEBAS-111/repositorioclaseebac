using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class componentes1 : MonoBehaviour 
{
    public static GameObject miObjeto;
    private void Awake()
    {
        
    }
    //started is called before the first frame updte
    void Start()
    {
        miObjeto = this.gameObject;
    }

    //update is called once per frame
    void Update()
    {

    }

}

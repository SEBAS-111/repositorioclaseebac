using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubespawner : MonoBehaviour 
{
    public GameObject prefabcubo;
    public List<GameObject> listaDeCubos;
    public float FactorDeEscalamiento;
    public int numcubos = 0;

    //start is called before the first frame update
    void Start()
    {
        listaDeCubos = new List<GameObject>();
    }

    //update is called once per frame
    void Update()
    {
        numcubos++;
        GameObject tempGameObject = Instantiate<GameObject>(prefabcubo);
        tempGameObject.name = "cuboNumero" + numcubos;
        Color c = new Color(Random.value,Random.value,Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;
        
        listaDeCubos.Add(tempGameObject);
        List<GameObject> objetosParaEliminar = new List<GameObject>();
        foreach (GameObject go in listaDeCubos)
        {
            float escala = go.transform.localScale.x;
            escala *= FactorDeEscalamiento;
            go.transform.localScale = Vector3.one * escala;

            if (escala <=0.1)
            {
                objetosParaEliminar.Add(go);
            }

        }

        foreach (GameObject go in objetosParaEliminar)
        {
            listaDeCubos.Remove(go);
            Destroy(go);
        }
    }
}

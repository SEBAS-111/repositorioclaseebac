using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCuboDeCero : MonoBehaviour
{

    GameObject objtoSpawn;
    Vector3[] vertices = {
        new Vector3 (0, 0, 0),  //vertice0
        new Vector3 (1, 0, 0),  //vertice1
        new Vector3 (1, 1, 0),  //vertice2
        new Vector3 (0, 1, 0),  //vertice3
        new Vector3 (0, 1, 1),  //vertice4
        new Vector3 (1, 1, 1),  //vertice5
        new Vector3 (1, 0, 1),  //vertice6
        new Vector3 (0, 0, 1),  //vertice7
    };

    int[] triangulos = {
        0, 2, 1, //cara 1
        0, 3, 2,
        2, 3, 4, //cara 2
        2, 4, 5,
        1, 2, 5, //cara 3
        1, 5, 6,
        0, 7, 4, //cara 4
        0, 4, 3,
        5, 4, 7, //cara 5
        5, 7, 6,
        0, 6, 7, //cara 6
        0, 1, 6
       };
    //started is called before the first frame updte
    void Start()
    {
        objtoSpawn = new GameObject("Nuestro Primer Cubo");
        objtoSpawn.AddComponent<MeshFilter>();
        var meshFilter = objtoSpawn.GetComponent<MeshFilter>().mesh;
        meshFilter.Clear();
        meshFilter.vertices = vertices;
        meshFilter.triangles = triangulos;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals();
        objtoSpawn.AddComponent<BoxCollider>();
        var boxcollider = objtoSpawn.GetComponent<BoxCollider>();
        boxcollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        objtoSpawn.AddComponent<MeshCollider>();
        var meshRendererMaterial = objtoSpawn.GetComponent<MeshRenderer>().material;
        meshRendererMaterial.color = Color.black;
        objtoSpawn.transform.position = Vector3.one;
    }

    //update is called once per frame
    void Update()
    {
        
    }
}

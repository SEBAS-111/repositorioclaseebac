using UnityEngine;

public class cubodesdeondeseable : MonoBehaviour
{

    private GameObject cuboGenerado; // Variable para almacenar la referencia del cubo

    void OnEnable()
    {
        GenerarCubo();
    }

    void OnDisable()
    {
        DestruirCubo();
    }

    void GenerarCubo()
    {
        cuboGenerado = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cuboGenerado.name = "Cubo Generado";

        cuboGenerado.transform.position = transform.position;


        Debug.Log("Cubo generado.");
    }

    void DestruirCubo()
    {
        // Destruye el cubo si existe
        if (cuboGenerado != null)
        {
            Destroy(cuboGenerado);
            Debug.Log("Cubo destruido.");
        }
    }

    void Start()
    {

    }

    void Update()
    {

    }

}

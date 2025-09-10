using UnityEngine;

public class cubodesdeondeseable : MonoBehaviour
{
    public GameObject cuboPrefab; 
    private GameObject instanciaCubo;

    void OnEnable()
    {
        
        Debug.Log("OnEnable: ¡Activando el script y generando el cubo!");

        if (cuboPrefab != null)
        {
            
            instanciaCubo = Instantiate(cuboPrefab, transform.position, Quaternion.identity);
            Debug.Log("Cubo generado en la posición: " + transform.position);
        }
        else
        {
            Debug.LogError("No se ha asignado un cuboPrefab al script.");
        }
    }

    void OnDisable()
    {
        
        Debug.Log("OnDisable: ¡Desactivando el script y destruyendo el cubo!");

        if (instanciaCubo != null)
        {
            
            Destroy(instanciaCubo);
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

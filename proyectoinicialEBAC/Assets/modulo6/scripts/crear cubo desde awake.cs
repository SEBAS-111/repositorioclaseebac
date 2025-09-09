using UnityEngine;

public class crearcubodesdeawake : MonoBehaviour
{
    private void Awake()
    {
        
        GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Cube);

        cubo.name = "MiCubodesdeAwake";

        Debug.Log("¡Cubo generado en Awake()!");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

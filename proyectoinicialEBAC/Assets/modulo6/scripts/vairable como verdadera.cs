using UnityEngine;

public class vairablecomoverdadera : MonoBehaviour
{
    GameObject GameObject_go;
    public bool esActivo = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (esActivo)
        {
            Debug.Log("la variable esActivo es verdadera.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

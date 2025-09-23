using UnityEngine;

public class vairablecomoverdadera : MonoBehaviour
{
    GameObject GameObject_go;
    public bool esActivo = true;

    public Color colorVerdadero = Color.white;
    public Color colorFalso = Color.black;

    private Renderer objectRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
    }


    void FixedUpdate()
    {

        if (esActivo)
        {
            objectRenderer.material.color = colorVerdadero;
        }
        else
        {
            objectRenderer.material.color = colorFalso;
        }


    }

    public void ToggleBoolean()
    {
        esActivo = !esActivo;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;

public class colorChanger : MonoBehaviour
{
    GameObject GameObject_go;
    public bool isTrue = false;

    
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
        
        if (isTrue)
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
        isTrue = !isTrue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

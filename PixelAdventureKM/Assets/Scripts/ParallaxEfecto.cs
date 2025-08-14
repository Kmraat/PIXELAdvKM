using UnityEngine;

public class ParallexEfecto : MonoBehaviour
{
    public Transform cam;
    public float parallaxFactor;
    private float inicioX;
    private float spriteWidth;
    private float anchoSprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inicioX = transform.position.x;
        anchoSprite = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float temp = (cam.position.x * (1 - parallaxFactor));
        float dist = (cam.position.x * parallaxFactor);
        transform.position = new Vector3(inicioX + dist, transform.position.y, transform.position.z);

        if (temp > inicioX + spriteWidth) inicioX += spriteWidth;

        else if (temp < inicioX - spriteWidth) inicioX -= spriteWidth;


    }
}


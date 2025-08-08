using UnityEngine;

public class ParallaxEfecto : MonoBehaviour
{

    public Transform camara;
    public float factor;
    private float inicioX;
    private float anchoSprite;

    void Start()
    {
        inicioX = transform.position.x;
        anchoSprite = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {

        float temp = (camara.position.x * (1 - factor));
        float dist = (camara.position.x * factor);


        transform.position = new Vector3(inicioX + dist, transform.position.y, transform.position.z);
        if (temp > inicioX + anchoSprite)
            inicioX += anchoSprite;
        else if (temp < inicioX - anchoSprite)
            inicioX -= anchoSprite;
    }

    float CalcularAnchoTotal()
    {
        float ancho = 0f;
        foreach (Transform hijo in transform)
        {
            SpriteRenderer sr = hijo.GetComponent<SpriteRenderer>();
            if (sr != null)
            {
                ancho += sr.bounds.size.x;
            }
        }
        return ancho;
    }
}

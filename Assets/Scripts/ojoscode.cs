using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ojoscode : MonoBehaviour
{
    public AudioSource sfxojos;
    private SpriteRenderer spriteojos;
    public float tiempoAparecer;
    public bool aparecio = false;
    float contador = 0f;
    // Start is called before the first frame update
    void Start()
    {
        spriteojos.color = new Color(1f, 1f, 1f, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (aparecio)
        {
            contador += Time.deltaTime;

            float nuevoAlpha = contador / tiempoAparecer ;
            
            spriteojos.color = new Color(1f, 1f, 1f, nuevoAlpha);

            if (contador >= tiempoAparecer)
            {
                aparecio = false;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            sfxojos.Play();
            aparecio = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportControl : MonoBehaviour
{
    public float posX;
    public float posY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            collision.transform.position = new Vector2(posX, posY);
        }
    }
    public void Teleport()
    {
        transform.position = new Vector2(posX, posY);
    }
}

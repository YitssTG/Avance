using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class enemyController : MonoBehaviour
{
    Rigidbody2D _commponentRigidbody2d;
    SpriteRenderer _spriteRenderer;
    Transform _transform;
    public int speedx = 1;
    public bool canKill;
    public float minlimit;
    public float maxlimit;
    
    
    // Start is called before the first frame update
    void Awake()
    {
        _transform = GetComponent<Transform>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
      _transform.position = new Vector2(_transform.position.x + speedx * Time.deltaTime, -0.68f);
        if (_transform.position.x >= maxlimit) 
        {
            speedx = speedx * -1;
            _spriteRenderer.flipX = true;
        }
        if (_transform.position.x <= minlimit) 
        {
            speedx = speedx * -1;
            _spriteRenderer.flipX = false;
        }
       
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "pared")
        {
            canKill = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "pared")
        {
            canKill = true;
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public float vida;
    public float maximavida;
    public float SpeedX;
    public float Horizontal;
    private Rigidbody2D _componentRigidBody2D;
    private Animator _componentAnimator;
    private SpriteRenderer _componentSpriteRenderer;
    public bool canJump;
    public bool isJumping;
    public float jumpForce;
    public bool canDoor;
    public TeleportControl teleport;
    public VidaBarra vidaBarra;

    private void Start()
    {
        vida = maximavida;
        vidaBarra.StartVidaBarra(vida);
    }
    public void TomarDaño(float daño)
    {
        vida -= daño;
        vidaBarra.CambiarVidaActual(vida);
        if(vida <= 0)
        {
            Destroy(gameObject);
        }
    }
    void Awake()
    {
        _componentRigidBody2D = GetComponent<Rigidbody2D>();
        _componentAnimator = GetComponent<Animator>();
        _componentSpriteRenderer = GetComponent<SpriteRenderer>();
        
    }
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        _componentAnimator.SetInteger("isWalking", (int)Horizontal);
        if (Horizontal < 0)
        {
            _componentSpriteRenderer.flipX = false;
        }
        else if (Horizontal > 0) 
        {
            _componentSpriteRenderer.flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) == true && canJump == true)
        {
            isJumping = true;
        }
        if (isJumping == true)
        {
            _componentAnimator.SetBool("isJumping", true);
        }
        if (Input.GetKeyDown(KeyCode.E) && canDoor == true)
        {
            teleport.Teleport();
        }
        
    }

    private void FixedUpdate()
    {
        _componentRigidBody2D.velocity = new Vector2(Horizontal * SpeedX, _componentRigidBody2D.velocity.y);
        
        if (isJumping == true)
        {
            _componentRigidBody2D.AddForce(new Vector2(0, jumpForce),ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            canJump = true;
            _componentAnimator.SetBool("isJumping", false);
        }
        if (collision.gameObject.tag == "enemy")
        {
            
            
            print("Jugador recibio daño");
        }
        if (collision.gameObject.tag == "enemy" )
        {

        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            canJump = false;
            isJumping = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            canDoor = true;
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        canDoor = false;
    }
    
}

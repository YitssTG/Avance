using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rapido : MonoBehaviour
{
    class Rapido : Enemigo
    {
        public Rapido(int vida, int damage, float speed)
        {
            this.vida = vida;
            this.damage = damage;
            this.speed = speed;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


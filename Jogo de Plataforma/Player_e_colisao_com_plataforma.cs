using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed, forceJump;
    public Rigidbody2D playerBody;
    public Transform posipe;
    private float walk;
    public LayerMask chao;
    private bool inground;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoviPlayer();
        CheckGround();
    }

    //Movimentos do Player
    void MoviPlayer()
    {
        walk = Input.GetAxisRaw("Horizontal");
        //Caminhar
        playerBody.velocity = new Vector2(walk * speed, playerBody.velocity.y);

        //Saltar
        if (inground && Input.GetKeyDown(KeyCode.Space))
        {
            playerBody.velocity = Vector2.up * forceJump;
        }

    }

    //Verificar se esta no chao
    void CheckGround()
    {
        inground = Physics2D.OverlapCircle(posipe.position, 0.3f, chao);
    }

    //Afilhar Player a plataforma
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Plataforma"))
        {
            this.transform.parent = col.transform;
        }

    }

    //Remover Parentesco do Player a plataforma
    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Plataforma"))
        {
            this.transform.parent = null;
        }
    }


}

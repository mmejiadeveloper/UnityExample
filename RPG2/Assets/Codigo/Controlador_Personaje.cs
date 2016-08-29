using UnityEngine;
using System.Collections;

public class Controlador_Personaje : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anm;
    SpriteRenderer sp;

    private float mov_en_x;
    private float mov_en_y;
    public float velocidad;
    private int idlestate;
    public bool moveside;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anm = GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();
    }
    void GiveIdleState()
    {

        if (mov_en_y > 0)
        {
            idlestate = 1;

        }
        if (mov_en_y < 0)
        {
            idlestate = 2;
        }

        if (mov_en_x != 0)
        {
            moveside = true;
            idlestate = 3;
        }
        else
        {
            moveside = false;
        }

        if (mov_en_x == 0 || mov_en_y== 0)
        {
            //anm.SetInteger("CamUp", 0);

        }
    }
    void Flip()
    {
        if (mov_en_x > 0 && !sp.flipX)
        {
            sp.flipX = true;
        }
        else
        {
            if (mov_en_x < 0 && sp.flipX)
            {
                sp.flipX = false;

            }
        }
    }
    void AnimCore()
    {
        anm.SetBool("mov_side", moveside);
        anm.SetFloat("mov_x", rb.velocity.x);
        anm.SetFloat("mov_y", rb.velocity.y);

        //if (rb.velocity == Vector2.zero)
        //{
            anm.SetInteger("idleState", idlestate);

        //}



    }
    void Config()
    {
        mov_en_x = Input.GetAxis("Horizontal");
        mov_en_y = Input.GetAxis("Vertical");

       
        GiveIdleState();
        //print(idlestate);

        //if (rb.velocity == Vector2.zero)
        //{
        //    GiveIdleState();
        //    print(idlestate);
        //}
    }

    void FixedUpdate()
    {
        AnimCore();
        Flip();
        Config();
        rb.velocity = new Vector2(mov_en_x * velocidad, mov_en_y * velocidad);
    }
}

using UnityEngine;
using System.Collections;

public class Controlador_Personaje : MonoBehaviour {
    Rigidbody2D rb;
    Animator anm;
    SpriteRenderer sp;

    private float mov_en_x;
    private float mov_en_y;
    public float velocidad;

    void Start () {
        rb = GetComponent<Rigidbody2D>();
        anm = GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();
    }

    void Config()
    {
        mov_en_x = Input.GetAxis("Horizontal");
        mov_en_y = Input.GetAxis("Vertical");

        anm.SetFloat("move", mov_en_y);
        anm.SetFloat("movex", mov_en_x);

        if (mov_en_x < 0)
        {
            
            anm.SetBool("movl", true);

        }
        else
        {
            anm.SetBool("movl", false);
        }

    }

    void Update () {
        Config();
        rb.velocity = new Vector2(mov_en_x*velocidad,mov_en_y*velocidad);
    }
}

using UnityEngine;
using System.Collections;

public class FindCombat : MonoBehaviour
{
    public Rigidbody2D _Player_Rigidbody;
    public GameObject _Canvas_Combate;
    public float frecuencia_de_combate;
    public float timer;
    void Start()
    {

    }
    void Update()
    {
        if(_Player_Rigidbody.velocity!=Vector2.zero)
        {
            timer += Time.deltaTime;
        }
        if (timer>= frecuencia_de_combate)
        {
            print("Entrar en combate!");
            _Canvas_Combate.SetActive(true);
            _Player_Rigidbody.gameObject.SetActive(false);
        }
    }
}

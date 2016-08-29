using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class Combat : MonoBehaviour
{
    public RectTransform _PosAttack;
    public RectTransform _PlayerPos;
    public Vector3 initialPlayerPosotion;
    public Image monster;
    void Start()
    {
        //initialPlayerPosotion = _PlayerPos.position;

    }
    public void BasicAttack()
    {
        //initialPlayerPosotion = _PlayerPos.position;

        _PlayerPos.position = _PosAttack.position;

        Invoke("Attack", 1);
    }

    void Attack()
    {
        //_PlayerPos.position = initialPlayerPosotion;
        monster.color = new Color(0, 0, 0, 1);
        Invoke("RestoreAttackPosition", 1);

    }

    void RestoreAttackPosition()
    {
        monster.color = new Color(1, 1, 1, 1);
        _PlayerPos.position = initialPlayerPosotion;
        CancelInvoke();
    }
}

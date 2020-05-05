using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bat : MonoBehaviour
{
    [Header("血量")]
    public int hp = 150;
    [Header("攻擊力")]
    public int att = 50;
    [Header("治愈量")]
    public int heal = 20;
    public Text result;
    public Slime slime;

    public void Attack()
    {
        slime.Injured();
    }

    public void Injured()
    {
        hp -= slime.att;
        result.text = "<color=#233123>" + gameObject.name + "</color> - 受到傷害：" + slime.att + "\n <color=#233123>" + gameObject.name + "</color> - 血量剩下：" + hp;
    }

    public void Heal()
    {
        hp += heal;
        result.text = "<color=#233123>" + gameObject.name + "</color> - 收到治愈：" + heal + "\n <color=#233123>" + gameObject.name + "</color> - 血量剩下：" + hp;
    }


}

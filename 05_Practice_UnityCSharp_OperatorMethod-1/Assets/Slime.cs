using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slime : MonoBehaviour
{
    [Header("血量")]
    public int hp = 200;
    [Header("攻擊力")]
    public int att = 20;
    [Header("治愈量")]
    public int heal = 10;
    public Text result;
    public Bat bat;

    public void Attack()
    {
        bat.Injured();
    }

    public void Injured()
    {
        hp -= bat.att;
        result.text = "<color=#9CA610>" + gameObject.name + "</color> - 受到傷害：" + bat.att + "\n <color=#9CA610>" + gameObject.name + "</color> - 血量剩下：" + hp;
    }

    public void Heal()
    {
        hp += heal;
        result.text = "<color=#9CA610>" + gameObject.name + "</color> - 收到治愈：" + heal + "\n <color=#9CA610>" + gameObject.name + "</color> - 血量剩下：" + hp;
    }


}

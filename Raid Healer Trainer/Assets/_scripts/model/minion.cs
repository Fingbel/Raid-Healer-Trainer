using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class minion
{
    public string name { get; protected set; }
    public int hp { get; protected set; }
    public Sprite sprite { get; set; }


    public minion (string name,int hp,Sprite sprite)
    {
        this.name = name;
        this.hp = hp;
        this.sprite = sprite;
    }

    public void getDamage(minion minion, int hit)
    {
        hp -= hit;

    }
}

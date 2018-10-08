using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class minion
{
    public int ID;
    public string name { get; protected set; }
    public string job;
    public int hp { get; set; }
    public int mp;
    public bool isDead;
    


    public minion (string name,int hp)
    {
        this.name = name;
        this.hp = hp;

    }

}

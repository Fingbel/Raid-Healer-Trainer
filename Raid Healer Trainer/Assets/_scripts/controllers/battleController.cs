using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class battleController : MonoBehaviour {

    public battle battle;
    Vector3 allySpawnPoint;
    Vector3 ennemySpawnPoint;
    List<minion> allyList;
    List<minion> ennemyList;
    public Sprite allySprite;
    public Sprite ennemySprite;
    public UIController UICtrl;

    // Use this for initialization
    void Start () {
        
        allySpawnPoint = GameObject.FindGameObjectWithTag("allySpawnPoint").transform.position;
        ennemySpawnPoint = GameObject.FindGameObjectWithTag("ennemySpawnPoint").transform.position;

        //Initialisation des listes de minions
        List<minion> ennemyList = new List<minion>();
        List<minion> allyList = new List<minion>();

        //FIXME - Remplissage de la liste d'ally
        allyList.Add(new minion("Gandalf",10)); //FIXME - HARDCODED
        allyList.Add(new minion("Frobite", 10)); //FIXME - HARDCODED
        allyList.Add(new minion("Sarouma,e", 10)); //FIXME - HARDCODED
        allyList.Add(new minion("HOUCAPOUPCA", 10)); //FIXME - HARDCODED
        allyList.Add(new minion("Gandalf", 10)); //FIXME - HARDCODED
        allyList.Add(new minion("Frobite", 10)); //FIXME - HARDCODED
        allyList.Add(new minion("Sarouma,e", 10)); //FIXME - HARDCODED
        allyList.Add(new minion("HOUCAPOUPCA", 10)); //FIXME - HARDCODED
        allyList.Add(new minion("Gandalf", 10)); //FIXME - HARDCODED
        allyList.Add(new minion("Frobite", 10)); //FIXME - HARDCODED
        allyList.Add(new minion("Sarouma,e", 10)); //FIXME - HARDCODED
        allyList.Add(new minion("HOUCAPOUPCA", 10)); //FIXME - HARDCODED
        allyList.Add(new minion("Gandalf", 10)); //FIXME - HARDCODED
        allyList.Add(new minion("Frobite", 10)); //FIXME - HARDCODED
        allyList.Add(new minion("Sarouma,e", 10)); //FIXME - HARDCODED
        allyList.Add(new minion("HOUCAPOUPCA", 10)); //FIXME - HARDCODED
        allyList.Add(new minion("Gandalf", 10)); //FIXME - HARDCODED
        allyList.Add(new minion("Frobite", 10)); //FIXME - HARDCODED
        allyList.Add(new minion("Sarouma,e", 10)); //FIXME - HARDCODED
        allyList.Add(new minion("HOUCAPOUPCA", 10)); //FIXME - HARDCODED
        allyList.Add(new minion("HOUCAPOUPCA", 10)); //FIXME - HARDCODED





        //FIXME - Remplissage de la liste d'ennemy

        ennemyList.Add(new minion("ennemy",10)); //FIXME - HARDCODED

        //contrustion de la bataille
        
        battle = new battle(ennemySpawnPoint, allySpawnPoint, allyList, ennemyList);

        //Boucle pour chaque Allié dans la liste d'alliés
        for (int i = 0; i < allyList.Count; i++)
        {
            minion Ally_data = battle.AllyList[i];

            GameObject Ally_go = new GameObject();

            Ally_go.name = Ally_data.name;

            //positionnement de l'ally
            Ally_go.transform.position = battle.spawnAlly(i);

            //gestion du sprite de l'ally
            Ally_go.AddComponent<SpriteRenderer>();
            Ally_go.GetComponent<SpriteRenderer>().sprite = allySprite;
            Ally_go.GetComponent<SpriteRenderer>().sortingLayerName = "minions";
            UICtrl.spawnCharButton(Ally_data.name);
            Debug.Log("Ally Gameobject "+Ally_data.name+" created");
            
        }

        //Boucle pour chaque ennemy dans la liste d'ennemy
        for (int i = 0; i < ennemyList.Count; i++)
        {
            minion ennemy_data = battle.EnnemyList[i];

            GameObject Ennemy_go = new GameObject();
            Ennemy_go.name = ennemyList[i].name;
            Ennemy_go.transform.position = battle.spawnEnnemy(i);

            //gestion du sprite de l'ennemy
            Ennemy_go.AddComponent<SpriteRenderer>();
            Ennemy_go.GetComponent<SpriteRenderer>().sprite = ennemySprite;
            Ennemy_go.GetComponent<SpriteRenderer>().sortingLayerName = "minions";

            Debug.Log("Ennemy Gameobject "+ennemy_data.name+" created");
        }
        Debug.Log("Battle Created");
    	}

}

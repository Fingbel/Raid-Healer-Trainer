using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour
{
    minion currentTarget;
    Vector3 lastFramePosition;
    Vector3 currentFramePosition;
    public Button char_button;
    public GameObject charPanel_canvas;
    public Sprite tooltip;
    public battle Battle;
    public battleController btlCtrl;

   
    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            btlCtrl.battle.damageMinion(1);

        }
    }

    void TaskOnClick()
    {

        btlCtrl.battle.setAllyTarget(currentTarget.ID);
        
        
    }

    public void spawnCharButton(minion currentMinion)
    {
        //Création des bouttons d'UI
        Button charbutton = Instantiate(char_button, transform.position, transform.rotation);
        charbutton.transform.SetParent(charPanel_canvas.transform);
        charbutton.onClick.AddListener(TaskOnClick);
 
        //Nommage des bouttons d'UI
        charbutton.GetComponentInChildren<Text>().text = currentMinion.name;
    }

          
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIController : MonoBehaviour
{

    Vector3 lastFramePosition;
    Vector3 currentFramePosition;
    public Button char_button;
    public GameObject charPanel_canvas;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void TaskOnClick()
    {
        Debug.Log("Click");
        

    }

    public void spawnCharButton(string name)
    {
        //Création des bouttons d'UI
        Button charbutton = Instantiate(char_button, transform.position, transform.rotation);
        charbutton.transform.SetParent(charPanel_canvas.transform);
        charbutton.onClick.AddListener(TaskOnClick);


        //Nommage des bouttons d'UI
        charbutton.GetComponentInChildren<Text>().text = name;
    }
          
}

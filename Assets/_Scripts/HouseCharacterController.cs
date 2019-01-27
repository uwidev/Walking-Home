﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HouseCharacterController : MonoBehaviour
{
    public float charaSpeed;
    public GameObject eventHandler;
    public GameObject statManager;
    public GameObject panel;

    private CharacterController myController;
    private EventFunctions functions;

    private StatsManagerController smc;
    private string currentTrigger;

    public bool canControl;

    public string currentTag;

    bool leftChoice = true;

    // Start is called before the first frame update
    void Start()
    {
        myController = GetComponent<CharacterController>();
        functions = eventHandler.GetComponent<EventFunctions>();
        smc = statManager.GetComponent<StatsManagerController>();
        currentTrigger = "";
        canControl = true;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        if(canControl)
        {
<<<<<<< HEAD
            panel.SetActive(true);
            Time.timeScale = 0;
            switch (collider.tag)
            {
                case "Door":
                    panel.transform.GetChild(0).GetComponent<Text>().text = "Leave?";
                    break;
                case "Stove":
                    if (smc.myFood > 0)
                    {
                        panel.transform.GetChild(0).GetComponent<Text>().text = "Make food?";
                        currentTrigger = "Stove";
                    }
                    break;
                case "Hole":
                    if (smc.myWood > 0)
                    {
                        panel.transform.GetChild(0).GetComponent<Text>().text = "Repair house?";
                        currentTrigger = "Hole";
                    }
                    break;
                case "Fireplace":
                    if (smc.myWood > 0)
                    {
                        panel.transform.GetChild(0).GetComponent<Text>().text = "Build Fire?";
                        currentTrigger = "Fireplace";
                    }
                    break;
            }
=======
            float moveX = Input.GetAxis("Horizontal");
            float moveY = Input.GetAxis("Vertical");
            Vector3 playerMove = new Vector3(moveX, 0.0f, moveY);
            myController.SimpleMove(playerMove * charaSpeed);
>>>>>>> 3f15d1d50dc199b6238314701f1e7665fd222e17
        }

    }

    private void OnTriggerStay(Collider collider)
    {
<<<<<<< HEAD
        panel.transform.GetChild(0).GetComponent<Text>().text = "";
        RunTriggerAction();
        //Time.timeScale = 1;
        //panel.SetActive(false);
    }
=======
>>>>>>> 3f15d1d50dc199b6238314701f1e7665fd222e17

        if (Input.GetKeyDown(KeyCode.E) && canControl)
        {
            Debug.Log("E pressed in Stay");
            canControl = false;
            panel.gameObject.SetActive(true);
            currentTag = collider.gameObject.tag;

            //OperateOnTag(collider.gameObject.tag);

            //print(panel.transform.GetChild(0).GetComponent<Text>().text);
            
        }
    }

    public void OperateOnTag(string tag)
    {
        switch (tag)
        {
            case "Stove":
                if(leftChoice)
                {
                    currentTag = "Stove2";
                    panel.transform.GetChild(0).GetComponent<Text>().text = "STOVE2";
                    //new stove
                    Debug.Log("STOVE2");
                }
                else
                {
                    panel.gameObject.SetActive(false);
                    panel.transform.GetChild(0).GetComponent<Text>().text = "";
                    currentTag = "";
                    canControl = true;
                }
                break;
<<<<<<< HEAD
            case "Hole":
                functions.HomeRepairRoof();
                Time.timeScale = 1;
                panel.SetActive(false);
=======

            case "Stove2":
                if(leftChoice)
                {
                    currentTag = "Stove3";
                    panel.transform.GetChild(0).GetComponent<Text>().text = "STOVE3";
                    Debug.Log("STOVE3");
                }
                else
                {
                    panel.gameObject.SetActive(false);
                    panel.transform.GetChild(0).GetComponent<Text>().text = "";
                    currentTag = "";
                    canControl = true;
                }
>>>>>>> 3f15d1d50dc199b6238314701f1e7665fd222e17
                break;

            case "Stove3":
                if (leftChoice)
                {
                    panel.gameObject.SetActive(false);
                    panel.transform.GetChild(0).GetComponent<Text>().text = "";
                    currentTag = "";
                    canControl = true;
                }
                else
                {
                    panel.gameObject.SetActive(false);
                    panel.transform.GetChild(0).GetComponent<Text>().text = "";
                    currentTag = "";
                    canControl = true;
                }

                break;
            
                
        }
        functions.UpdateAll();
    }

    public void A()
    {
        leftChoice = true;
        OperateOnTag(currentTag);
    }

    public void B()
    {
        leftChoice = false;
        OperateOnTag(currentTag);
    }

}

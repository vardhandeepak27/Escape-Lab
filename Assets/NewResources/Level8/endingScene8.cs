﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endingScene8 : MonoBehaviour, IInteractable8
{

    public GameObject EscapeMessage;

    public GameObject NextLevel;

    public GameObject OpenDoor;

    //private DisplayImage currentDisplay;
    private float initialCameraSize;
    private Vector3 initialCameraPosition;

    private void Start()
    {
        NextLevel.SetActive(false);
        OpenDoor.SetActive(false);
    }

    void Awake()
    {
        //currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage>();
        initialCameraSize = Camera.main.orthographicSize;
        initialCameraPosition = Camera.main.transform.position;
    }

    public void Interact8(DisplayImage8 currentDisplay)
    {
        currentDisplay.GetComponent<SpriteRenderer>().sprite
                = Resources.Load<Sprite>("Sprites/wall8" + currentDisplay.CurrentWall);
        currentDisplay.CurrentState = DisplayImage8.State.normal;

        Camera.main.orthographicSize = initialCameraSize;
        Camera.main.transform.position = initialCameraPosition;

        NextLevel.SetActive(true);
        OpenDoor.SetActive(true);
        this.gameObject.SetActive(false);

        //this.gameObject.layer = 2;

        Instantiate(EscapeMessage, GameObject.Find("Canvas").transform);
    }
}

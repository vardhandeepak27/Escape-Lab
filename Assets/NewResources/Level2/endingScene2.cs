using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endingScene2 : MonoBehaviour, IInteractable2 {

    public GameObject EscapeMessage;

    public GameObject NextLevel;

    public GameObject OpenDoor;
    public GameObject key;

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

    public void Interact2(DisplayImage2 currentDisplay)
    {
        currentDisplay.GetComponent<SpriteRenderer>().sprite
                = Resources.Load<Sprite>("Sprites/wall2" + currentDisplay.CurrentWall);
        currentDisplay.CurrentState = DisplayImage2.State.normal;

        Camera.main.orthographicSize = initialCameraSize;
        Camera.main.transform.position = initialCameraPosition;

        NextLevel.SetActive(true);
        OpenDoor.SetActive(true);
        key.SetActive(false);

        this.gameObject.layer = 2;

        Instantiate(EscapeMessage, GameObject.Find("Canvas").transform);

        //currentDisplay.CurrentState = DisplayImage.State.idle;

        //StartCoroutine(LoadNextLevel());

    }

    //public IEnumerator LoadNextLevel()
    //{   
    //    Debug.Log("Working1");
    //    yield return new WaitForSeconds (1);
    //    Debug.Log("Working2");
    //    SceneManager.LoadScene("Level2");
    //}
}

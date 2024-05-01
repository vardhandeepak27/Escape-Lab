using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour {

    private DisplayImage currentDisplay;

    private float initialCameraSize;
    private Vector3 initialCameraPosition;

    private ZoomInObject[] zoomInObjects;

    private GameObject wrongEqnMsg;

    public GameObject tutorial1;
    public GameObject tutorial2;
    public GameObject tutorial3;
    public GameObject tutorial4;
    public GameObject tutorial5;

    void Awake()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage>();
        initialCameraSize = Camera.main.orthographicSize;
        initialCameraPosition = Camera.main.transform.position;

        zoomInObjects = FindObjectsOfType<ZoomInObject>();

        wrongEqnMsg = GameObject.Find("WrongEqnMsg");

        tutorial1.SetActive(false);
        tutorial2.SetActive(false);
        tutorial3.SetActive(false);
        tutorial4.SetActive(false);
        tutorial5.SetActive(false);
    }

    //public void OnRightClickArrow()
    //{
    //    if (currentDisplay.CurrentState == DisplayImage.State.idle) return;

    //    currentDisplay.CurrentWall = currentDisplay.CurrentWall + 1;
    //}

    //public void OnLeftClickArrow()
    //{
    //    if (currentDisplay.CurrentState == DisplayImage.State.idle) return;

    //    currentDisplay.CurrentWall = currentDisplay.CurrentWall - 1;
    //}

    //public void OnClickReturn()
    //{
    //    if (currentDisplay.CurrentState == DisplayImage.State.idle) return;

    //    if (currentDisplay.CurrentState == DisplayImage.State.zoom)
    //    {
    //        currentDisplay.CurrentState = DisplayImage.State.normal;

    //        foreach (var zoomInObject in zoomInObjects)
    //        {
    //            zoomInObject.gameObject.layer = 0;
    //        }

    //        Camera.main.orthographicSize = initialCameraSize;
    //        Camera.main.transform.position = initialCameraPosition;
    //    }
    //    else
    //    {
    //        currentDisplay.GetComponent<SpriteRenderer>().sprite
    //            = Resources.Load<Sprite>("Sprites/wall" + currentDisplay.CurrentWall);
    //        currentDisplay.CurrentState = DisplayImage.State.normal;

    //        Camera.main.orthographicSize = initialCameraSize;
    //        Camera.main.transform.position = initialCameraPosition;

    //        foreach (var zoomInObject in zoomInObjects)
    //        {
    //            zoomInObject.gameObject.layer = 0;
    //        }
    //    }
    //}

    public void OnClickPlay()
    {
        SceneManager.LoadScene("escapeLab game");
    }

    public void OnClickNextLevel()
    {
        SceneManager.LoadScene("Level2");
    }

    public void OnClickExit()
    {
        Application.Quit();
    }

    public void OnClickReadMessage(GameObject TextObject)
    {
        //currentDisplay.CurrentState = DisplayImage.State.normal;

        tutorial1.SetActive(true);
        currentDisplay.CurrentState = DisplayImage.State.normal;

        Destroy(TextObject);
    }

    //public void OnClickTutorial1()
    //{
    //    Destroy(tutorial1);
    //}

    //public void OnClickBackpack()
    //{
    //    SceneManager.LoadScene("Backpack");
    //}

    public void OnClickTryAgain()
    {
        wrongEqnMsg.SetActive(false);
    }

    //public void OnClickGeneralTutorial(GameObject TutorialObject)
    //{
    //    Destroy(TutorialObject);
    //}

    public void OnClickOkay()
    {   
        if (tutorial4 != null)
        {
            Destroy(tutorial4);
        }
        //Destroy(tutorial4);
    }

    public void OnClickGotit()
    {
        if (tutorial5 != null)
        {
            Destroy(tutorial5);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler13 : MonoBehaviour {

    private DisplayImage13 currentDisplay;

    private float initialCameraSize;
    private Vector3 initialCameraPosition;

    private ZoomInObject[] zoomInObjects;
    private GameObject wrongEqnMsg;

    void Awake()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage13>();
        initialCameraSize = Camera.main.orthographicSize;
        initialCameraPosition = Camera.main.transform.position;

        zoomInObjects = FindObjectsOfType<ZoomInObject>();
        wrongEqnMsg = GameObject.Find("WrongEqnMsg");
    }

    //public void OnClickReturn()
    //{
    //    if (currentDisplay.CurrentState == DisplayImage7.State.idle) return;

    //    if (currentDisplay.CurrentState == DisplayImage7.State.zoom)
    //    {
    //        currentDisplay.CurrentState = DisplayImage7.State.normal;

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
    //            = Resources.Load<Sprite>("Sprites/wall7" + currentDisplay.CurrentWall);
    //        currentDisplay.CurrentState = DisplayImage7.State.normal;

    //        Camera.main.orthographicSize = initialCameraSize;
    //        Camera.main.transform.position = initialCameraPosition;

    //        foreach (var zoomInObject in zoomInObjects)
    //        {
    //            zoomInObject.gameObject.layer = 0;
    //        }
    //    }
    //}

    public void OnClickNextLevel()
    {
        SceneManager.LoadScene("Level 14");
    }

    public void OnClickExit()
    {
        Application.Quit();
    }

    public void OnClickReadMessage(GameObject TextObject)
    {
        currentDisplay.CurrentState = DisplayImage13.State.normal;

        Destroy(TextObject);
    }

    public void OnClickTryAgain()
    {
        wrongEqnMsg.SetActive(false);
    }

}

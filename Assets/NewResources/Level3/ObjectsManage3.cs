using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsManage3 : MonoBehaviour {

    private DisplayImage3 currentDisplay;

    public GameObject[] ObjectsToMange;
    public GameObject[] UIRenderObjects;

    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage3>();
        RenderUI();
    }

    void Update()
    {
        MangeObjects();
    }

    void MangeObjects()
    {
        for (int i = 0; i < ObjectsToMange.Length; i++)
        {
            if (ObjectsToMange[i].name == currentDisplay.GetComponent<SpriteRenderer>().sprite.name)
            {
                ObjectsToMange[i].SetActive(true);
            }
            else
            {
                ObjectsToMange[i].SetActive(false);
            }
        }
    }

    void RenderUI()
    {
        for (int i = 0; i < UIRenderObjects.Length; i++)
        {
            UIRenderObjects[i].SetActive(false);
        }
    }
}

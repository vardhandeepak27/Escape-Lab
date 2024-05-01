using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact14 : MonoBehaviour {

    private DisplayImage14 currentDisplay;

    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage14>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 rayPostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(rayPostion, Vector2.zero, 100);

            if (hit && hit.transform.tag == "Interactable14" && currentDisplay.CurrentState != DisplayImage14.State.idle)
            {
                hit.transform.GetComponent<IInteractable14>().Interact14(currentDisplay);
            }
        }

    }
}

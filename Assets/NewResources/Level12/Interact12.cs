using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact12 : MonoBehaviour {

    private DisplayImage12 currentDisplay;

    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage12>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 rayPostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(rayPostion, Vector2.zero, 100);

            if (hit && hit.transform.tag == "Interactable12" && currentDisplay.CurrentState != DisplayImage12.State.idle)
            {
                hit.transform.GetComponent<IInteractable12>().Interact12(currentDisplay);
            }
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact9 : MonoBehaviour {

    private DisplayImage9 currentDisplay;

    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage9>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 rayPostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(rayPostion, Vector2.zero, 100);

            if (hit && hit.transform.tag == "Interactable9" && currentDisplay.CurrentState != DisplayImage9.State.idle)
            {
                hit.transform.GetComponent<IInteractable9>().Interact9(currentDisplay);
            }
        }

    }
}

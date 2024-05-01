using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact13 : MonoBehaviour {

    private DisplayImage13 currentDisplay;

    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage13>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 rayPostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(rayPostion, Vector2.zero, 100);

            if (hit && hit.transform.tag == "Interactable13" && currentDisplay.CurrentState != DisplayImage13.State.idle)
            {
                hit.transform.GetComponent<IInteractable13>().Interact13(currentDisplay);
            }
        }

    }
}

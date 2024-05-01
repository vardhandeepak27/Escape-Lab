using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact11 : MonoBehaviour {

    private DisplayImage11 currentDisplay;

    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage11>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 rayPostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(rayPostion, Vector2.zero, 100);

            if (hit && hit.transform.tag == "Interactable11" && currentDisplay.CurrentState != DisplayImage11.State.idle)
            {
                hit.transform.GetComponent<IInteractable11>().Interact11(currentDisplay);
            }
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact5 : MonoBehaviour {

    private DisplayImage5 currentDisplay;

    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage5>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 rayPostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(rayPostion, Vector2.zero, 100);

            if (hit && hit.transform.tag == "Interactable5" && currentDisplay.CurrentState != DisplayImage5.State.idle)
            {
                hit.transform.GetComponent<IInteractable5>().Interact5(currentDisplay);
            }
        }

    }
}

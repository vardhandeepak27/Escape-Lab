using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact6 : MonoBehaviour {

    private DisplayImage6 currentDisplay;

    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage6>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 rayPostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(rayPostion, Vector2.zero, 100);

            if (hit && hit.transform.tag == "Interactable6" && currentDisplay.CurrentState != DisplayImage6.State.idle)
            {
                hit.transform.GetComponent<IInteractable6>().Interact6(currentDisplay);
            }
        }

    }
}

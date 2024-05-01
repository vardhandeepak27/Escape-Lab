using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact2 : MonoBehaviour {

    private DisplayImage2 currentDisplay;

    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage2>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 rayPostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(rayPostion, Vector2.zero, 100);

            if(hit && hit.transform.tag == "Interactable2" && currentDisplay.CurrentState != DisplayImage2.State.idle)
            {
                hit.transform.GetComponent<IInteractable2>().Interact2(currentDisplay);
            }
        }

    }
}

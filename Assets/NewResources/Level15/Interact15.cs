using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact15 : MonoBehaviour {

    private DisplayImage15 currentDisplay;

    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage15>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 rayPostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(rayPostion, Vector2.zero, 100);

            if (hit && hit.transform.tag == "Interactable15" && currentDisplay.CurrentState != DisplayImage15.State.idle)
            {
                hit.transform.GetComponent<IInteractable15>().Interact15(currentDisplay);
            }
        }

    }
}

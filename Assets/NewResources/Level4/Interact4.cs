using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact4 : MonoBehaviour {

    private DisplayImage4 currentDisplay;

    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage4>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 rayPostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(rayPostion, Vector2.zero, 100);

            if (hit && hit.transform.tag == "Interactable4" && currentDisplay.CurrentState != DisplayImage4.State.idle)
            {
                hit.transform.GetComponent<IInteractable4>().Interact4(currentDisplay);
            }
        }

    }
}

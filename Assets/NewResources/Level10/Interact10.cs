using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact10 : MonoBehaviour {

    private DisplayImage10 currentDisplay;

    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage10>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 rayPostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(rayPostion, Vector2.zero, 100);

            if (hit && hit.transform.tag == "Interactable10" && currentDisplay.CurrentState != DisplayImage10.State.idle)
            {
                hit.transform.GetComponent<IInteractable10>().Interact10(currentDisplay);
            }
        }

    }
}

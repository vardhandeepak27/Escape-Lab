using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact3 : MonoBehaviour {

    private DisplayImage3 currentDisplay;

    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage3>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 rayPostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(rayPostion, Vector2.zero, 100);

            if (hit && hit.transform.tag == "Interactable3" && currentDisplay.CurrentState != DisplayImage3.State.idle)
            {
                hit.transform.GetComponent<IInteractable3>().Interact3(currentDisplay);
            }
        }

    }
}

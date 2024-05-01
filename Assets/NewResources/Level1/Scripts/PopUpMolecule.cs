using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpMolecule : MonoBehaviour, IInteractable
{

    public GameObject item;

    //public GameObject tutorial2;

    void Start()
    {
        item.SetActive(false);
        //tutorial2.SetActive(false);
    }

    public void Interact(DisplayImage currentDisplay)
    {
        item.SetActive(true);
        this.gameObject.SetActive(false);
    }
}

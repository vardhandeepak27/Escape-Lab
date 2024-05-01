using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpMolecule5 : MonoBehaviour, IInteractable5
{

    public GameObject item;

    void Start()
    {
        item.SetActive(false);
    }

    public void Interact5(DisplayImage5 currentDisplay)
    {
        item.SetActive(true);
        this.gameObject.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpMolecule4 : MonoBehaviour, IInteractable4
{

    public GameObject item;

    void Start()
    {
        item.SetActive(false);
    }

    public void Interact4(DisplayImage4 currentDisplay)
    {
        item.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
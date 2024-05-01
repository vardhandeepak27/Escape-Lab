using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpMolecule6 : MonoBehaviour, IInteractable6
{

    public GameObject item;

    void Start()
    {
        item.SetActive(false);
    }

    public void Interact6(DisplayImage6 currentDisplay)
    {
        item.SetActive(true);
        this.gameObject.SetActive(false);
    }
}

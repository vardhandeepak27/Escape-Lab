using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpMolecule15 : MonoBehaviour, IInteractable15
{
    
    public GameObject item;
    public GameObject item1;
    //public GameObject item2;

    void Start()
    {
        item.SetActive(false);
        item1.SetActive(false);
        //item2.SetActive(false);
    }

    public void Interact15(DisplayImage15 currentDisplay)
    {
        item.SetActive(true);
        item1.SetActive(true);
        //item2.SetActive(true);
        this.gameObject.SetActive(false);
    }
}

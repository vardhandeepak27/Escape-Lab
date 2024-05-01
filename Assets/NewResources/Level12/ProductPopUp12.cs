using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductPopUp12 : MonoBehaviour, IInteractable12 {

    public GameObject item;
    //public GameObject item1;
    //public GameObject item2;

    void Start()
    {
        item.SetActive(false);
        //item1.SetActive(false);
        //item2.SetActive(false);
    }

    public void Interact12(DisplayImage12 currentDisplay)
    {
        item.SetActive(true);
        //item1.SetActive(true);
        //item2.SetActive(true);
        this.gameObject.SetActive(false);
    }
}

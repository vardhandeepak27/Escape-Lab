using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpMolecule3 : MonoBehaviour, IInteractable3 {

    public GameObject item;
    public GameObject item1;
    //public GameObject item2;

    public GameObject tutorial;

    void Start()
    {
        item.SetActive(false);
        item1.SetActive(false);
        //item2.SetActive(false);

        tutorial.SetActive(false);
    }

    public void Interact3(DisplayImage3 currentDisplay)
    {
        item.SetActive(true);
        item1.SetActive(true);
        //item2.SetActive(true);
        this.gameObject.SetActive(false);

        if (tutorial != null)
        {
            tutorial.SetActive(true);
        }
    }
}

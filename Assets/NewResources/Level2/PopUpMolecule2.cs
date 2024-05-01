using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpMolecule2 : MonoBehaviour, IInteractable2 {

    public GameObject item;

	void Start () {
        item.SetActive(false);
	}
	
    public void Interact2(DisplayImage2 currentDisplay)
    {
        item.SetActive(true);
        this.gameObject.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicsObject4 : MonoBehaviour, IInteractable4
{

    public GameObject ChangedStateSprite;

    public enum InteractionProperty { simple_interaction, access_interaction }
    public InteractionProperty Property;

    public string UnlockItem;
    public GameObject AccessObject;


    private GameObject inventory;


    void Start()
    {
        ChangedStateSprite.SetActive(false);
        inventory = GameObject.Find("Inventory");

        if (Property == InteractionProperty.simple_interaction) return;
        AccessObject.SetActive(false);
    }



    public void Interact4(DisplayImage4 currentDisplay)
    {
        if (inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name == UnlockItem || UnlockItem == "")
        {
            ChangedStateSprite.SetActive(true);
            this.gameObject.layer = 2;

            if (Property == InteractionProperty.simple_interaction) return;
            inventory.GetComponent<Inventory>().currentSelectedSlot.GetComponent<Slot>().ClearSlot();
            AccessObject.SetActive(true);
        }

    }
}

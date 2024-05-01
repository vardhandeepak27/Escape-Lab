using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// Add this to cube1 and cube2 to make third molecule pop up after finding two molecules.
/// </summary>


public class CombinedItem : MonoBehaviour
{
    //private GameObject box1;
    //private GameObject box2;

    public string boxbutton1;
    public string boxbutton2;


    void Start()
    {
        //box1 = GameObject.Find("cube1");
        //box2 = GameObject.Find("cube2");
    }

    private void OnMouseDown()
    {
        if (this.gameObject.name == "cube1")
        {
            boxbutton1 = "yes";
            //this.GetComponent<BoxCollider2D>().enabled = false;
            //this.gameObject.GetComponent<PopUpMolecule>().enabled = false;
            //this.gameObject.GetComponent<ItemTextControl>().enabled = false;

        }
        else if (this.gameObject.name == "cube2")
        {
            boxbutton2 = "yes";
            //this.GetComponent<BoxCollider2D>().enabled = false;
            //this.gameObject.GetComponent<PopUpMolecule>().enabled = false;
            //this.gameObject.GetComponent<ItemTextControl>().enabled = false;
        }

    }

}


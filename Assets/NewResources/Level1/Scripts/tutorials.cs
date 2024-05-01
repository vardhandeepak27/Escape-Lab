using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorials : MonoBehaviour {

    private GameObject slot1;
    private GameObject slot2;
    private GameObject slot3;

    private GameObject molecule1;
    private GameObject cube2;

    public Sprite transparentSprite;

    //public GameObject tutorial3msg;

    public GameObject tutorial1msg;
    public GameObject tutorial2msg;
    public GameObject tutorial3msg;
    public GameObject tutorial4msg;
    public GameObject tutorial5msg;

    public Sprite Mg;
    public Sprite O2;
    public Sprite MgO;

    private void Start()
    {
        slot1 = GameObject.Find("1st slot");
        slot2 = GameObject.Find("2nd Slot");
        slot3 = GameObject.Find("3rd Slot");
        cube2 = GameObject.Find("cube2");
    }

    private void OnMouseDown()
    {   
        if (this.gameObject == cube2)
        {
            //Debug.Log("reached!");

            if (tutorial1msg != null)
            {
                Destroy(tutorial1msg);
                tutorial2msg.SetActive(true);
            }

            //tutorial1msg.SetActive(false);
        }

        if ((slot3.GetComponent<equationBox>().slotButton3 == "selected" &&
             slot3.GetComponent<SpriteRenderer>().sprite != transparentSprite) ||
            (slot1.GetComponent<equationBox>().slotButton1 == "selected" &&
             slot1.GetComponent<SpriteRenderer>().sprite != transparentSprite) || 
            (slot2.GetComponent<equationBox>().slotButton2 == "selected" &&
             slot2.GetComponent<SpriteRenderer>().sprite != transparentSprite))
        {
            if (tutorial3msg != null && tutorial2msg != null)
            {
                tutorial3msg.SetActive(true);
                //tutorial2msg.SetActive(false); 
                Destroy(tutorial2msg);
            }
        }

        if (slot3.GetComponent<equationBox>().slotButton3 == "selected2" ||
           slot1.GetComponent<equationBox>().slotButton1 == "selected2"  ||
           slot2.GetComponent<equationBox>().slotButton2 == "selected2")
        {   
            if ((tutorial3msg != null && tutorial4msg != null))
            {
                Destroy(tutorial3msg);
                tutorial4msg.SetActive(true);
            }
           
        }

        if ((slot1.GetComponent<SpriteRenderer>().sprite == Mg 
             || slot1.GetComponent<SpriteRenderer>().sprite == O2) && 
            (slot2.GetComponent<SpriteRenderer>().sprite == Mg ||
             slot2.GetComponent<SpriteRenderer>().sprite == O2) && 
            (slot3.GetComponent<SpriteRenderer>().sprite == MgO))
        {
            if (tutorial5msg != null)
            {
                tutorial5msg.SetActive(true);
            }
        }
    }
}


//slot1.GetComponent<equationBox>().slotButton1 == "" &&
//slot2.GetComponent<equationBox>().slotButton2 == "" &&
//slot2.GetComponent<equationBox>().slotButton2 == "" &&
//slot3.GetComponent<equationBox>().slotButton3 == "" &&


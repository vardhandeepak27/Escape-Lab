using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTextControl : MonoBehaviour {

    public Transform popuptext;
    public static string textstatus = "off";
    public string message;


    public GameObject molecule1;
    public GameObject molecule2;

    public GameObject eqnbox;

    void OnMouseEnter()
    {
        //if (this.gameObject == product)
        //{
        //    if (textstatus == "off")
        //    {
        //        popuptext.GetComponent<TextMesh>().text = message;


        //        textstatus = "on";
        //        Instantiate(popuptext, new Vector3(transform.position.x - 1.3f, transform.position.y + 2f, 0), popuptext.rotation);
        //    }
        //}

        if (this.gameObject == molecule1 || this.gameObject == molecule2)
        {
            //if (box1.gameObject.GetComponent<CombinedItems>().boxbutton1 == "yes" && box2.gameObject.GetComponent<CombinedItems>().boxbutton2 == "yes")

                if (textstatus == "off")
                {
                    popuptext.GetComponent<TextMesh>().text = message;

                    textstatus = "on";
                    Instantiate(popuptext, new Vector3(transform.position.x - 1f, transform.position.y, 0), popuptext.rotation);
                }
        }

        else if (this.gameObject == eqnbox)
        {
            if (textstatus == "off")
            {
                //if (gameObject.name == "Mg")
                //{
                popuptext.GetComponent<TextMesh>().text = message;
                //}

                textstatus = "on";
                Instantiate(popuptext, new Vector3(transform.position.x - 3f, transform.position.y + 2f, 0), popuptext.rotation);
            }
        }

        else{
            if (textstatus == "off")
            {
                popuptext.GetComponent<TextMesh>().text = message;

                textstatus = "on";
                Instantiate(popuptext, new Vector3(transform.position.x - 1f, transform.position.y, 0), popuptext.rotation);
            }
        }
    }

    void OnMouseExit()
    {
        if (textstatus == "on")
        {
            textstatus = "off";

        }
    }

    private void OnMouseDown()
    {
        if (textstatus == "on")
        {
            textstatus = "off";
        }
    }
}

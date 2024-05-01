using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class moleculeSelection: MonoBehaviour
{
    public GameObject molecule1;
    public GameObject molecule2;
    public GameObject molecule3;

    //public GameObject box1;
    //public GameObject box2;

    //public string button1;
    //public string button2;

    //public GameObject product;
    public GameObject NextLevel;

    //public GameObject eqnmolecule1;
    //public GameObject eqnmolecule2;

    public string movingButton1;
    public string movingButton2;
    public string movingButton3;

    private Color oldColour;
    private Color selectedColour;

    //private string selectedMolecule;
    //private GameObject moleculeToLoad;

    void Start()
    {
        //product.SetActive(false);
        NextLevel.SetActive(false);
        oldColour = new Color(1f, 1f, 1f, 1f);
        selectedColour = new Color(0.75f, 0.75f, 0.75f, 1f);
        //eqnmolecule1.SetActive(false);
        //eqnmolecule2.SetActive(false);
    }

    private void OnMouseDown()
    {
  
        //if (box1.gameObject.GetComponent<CombinedItems>().boxbutton1 == "yes" && box2.gameObject.GetComponent<CombinedItems>().boxbutton2 == "yes")

            if (this.gameObject.name == "Molecule1")
            {
                //button1 = "none";
                movingButton1 = "selected";
                molecule2.GetComponent<moleculeSelection>().movingButton2 = "";
                molecule3.GetComponent<moleculeSelection>().movingButton3 = "";

                molecule2.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                molecule3.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                molecule1.GetComponent<SpriteRenderer>().color = selectedColour;

                //this.gameObject.SetActive(false);
                //eqnmolecule1.SetActive(true);
            }
            else if (this.gameObject.name == "Molecule2")
            {
                //button2 = "none";
                movingButton2 = "selected";
                molecule1.GetComponent<moleculeSelection>().movingButton1 = "";
                molecule3.GetComponent<moleculeSelection>().movingButton3 = "";

                molecule1.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                molecule3.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                molecule2.GetComponent<SpriteRenderer>().color = selectedColour;
                //this.gameObject.SetActive(false);
                //eqnmolecule2.SetActive(true);
            }

            else if (this.gameObject.name == "Molecule3")
            {
                movingButton3 = "selected";
                molecule1.GetComponent<moleculeSelection>().movingButton1 = "";
                molecule2.GetComponent<moleculeSelection>().movingButton2 = "";

                molecule2.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                molecule1.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                molecule3.GetComponent<SpriteRenderer>().color = selectedColour;
            }
            //New();


        //selectedMolecule = this.gameObject.name;

        //if (selectedMolecule == "Molecule1" || selectedMolecule == "Molecule2") 
        //{
        //    moleculeToLoad = this.gameObject;
        //}



    }


    //private void New()
    //{
    //    if (molecule1.gameObject.GetComponent<Combination3>().button1 == "none" && molecule2.gameObject.GetComponent<Combination3>().button2 == "none")
    //    {
    //        //product.SetActive(true);
    //        molecule3.SetActive(true);
    //    }
    //}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class moleculeSelectionFake: MonoBehaviour
{
    public GameObject molecule1;
    public GameObject molecule2;
    public GameObject molecule3;

    public GameObject fakeMolecule11;
    //public GameObject fakeMolecule12;
    public GameObject fakeMolecule21;
    //public GameObject fakeMolecule22;
    //public GameObject fakeMolecule31;
    //public GameObject fakeMolecule32;

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

    public string fakeMove11;
    //public string fakeMove12;
    public string fakeMove21;
    //public string fakeMove22;
    //public string fakeMove31;
    //public string fakeMove32;

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

        if (this.gameObject == molecule1)
            {
                //button1 = "none";
                movingButton1 = "selected";
                molecule2.GetComponent<moleculeSelectionFake>().movingButton2 = "";
                molecule3.GetComponent<moleculeSelectionFake>().movingButton3 = "";

                fakeMolecule11.GetComponent<moleculeSelectionFake>().fakeMove11 = "";
                //fakeMolecule12.GetComponent<moleculeSelectionFake>().fakeMove12 = "";
                fakeMolecule21.GetComponent<moleculeSelectionFake>().fakeMove21 = "";
                //fakeMolecule22.GetComponent<moleculeSelectionFake>().fakeMove22 = "";
                //fakeMolecule31.GetComponent<moleculeSelectionFake>().fakeMove31 = "";
                //fakeMolecule32.GetComponent<moleculeSelectionFake>().fakeMove32 = "";

                molecule2.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                molecule3.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                molecule1.GetComponent<SpriteRenderer>().color = selectedColour;

                fakeMolecule11.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                //fakeMolecule12.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                fakeMolecule21.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                //fakeMolecule22.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                //fakeMolecule31.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                //fakeMolecule32.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                
                //this.gameObject.SetActive(false);
                //eqnmolecule1.SetActive(true);
            }
        else if (this.gameObject == molecule2)
            {
                //button2 = "none";
                movingButton2 = "selected";
                molecule1.GetComponent<moleculeSelectionFake>().movingButton1 = "";
                molecule3.GetComponent<moleculeSelectionFake>().movingButton3 = "";

                fakeMolecule11.GetComponent<moleculeSelectionFake>().fakeMove11 = "";
                //fakeMolecule12.GetComponent<moleculeSelectionFake>().fakeMove12 = "";
                fakeMolecule21.GetComponent<moleculeSelectionFake>().fakeMove21 = "";
                //fakeMolecule22.GetComponent<moleculeSelectionFake>().fakeMove22 = "";
                //fakeMolecule31.GetComponent<moleculeSelectionFake>().fakeMove31 = "";
                //fakeMolecule32.GetComponent<moleculeSelectionFake>().fakeMove32 = "";

                molecule1.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                molecule3.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                molecule2.gameObject.GetComponent<SpriteRenderer>().color = selectedColour;

                fakeMolecule11.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                //fakeMolecule12.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                fakeMolecule21.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                //fakeMolecule22.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                //fakeMolecule31.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                //fakeMolecule32.gameObject.GetComponent<SpriteRenderer>().color = oldColour;

                //this.gameObject.SetActive(false);
                //eqnmolecule2.SetActive(true);
            }

        else if (this.gameObject == molecule3)
            {   
                movingButton3 = "selected";
                molecule1.GetComponent<moleculeSelectionFake>().movingButton1 = "";
                molecule2.GetComponent<moleculeSelectionFake>().movingButton2 = "";

                fakeMolecule11.GetComponent<moleculeSelectionFake>().fakeMove11 = "";
                //fakeMolecule12.GetComponent<moleculeSelectionFake>().fakeMove12 = "";
                fakeMolecule21.GetComponent<moleculeSelectionFake>().fakeMove21 = "";
                //fakeMolecule22.GetComponent<moleculeSelectionFake>().fakeMove22 = "";
                //fakeMolecule31.GetComponent<moleculeSelectionFake>().fakeMove31 = "";
                //fakeMolecule32.GetComponent<moleculeSelectionFake>().fakeMove32 = "";

                molecule1.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                molecule2.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                molecule3.gameObject.GetComponent<SpriteRenderer>().color = selectedColour;

                fakeMolecule11.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                //fakeMolecule12.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                fakeMolecule21.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                //fakeMolecule22.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                //fakeMolecule31.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
                //fakeMolecule32.gameObject.GetComponent<SpriteRenderer>().color = oldColour;

            }

        else if (this.gameObject == fakeMolecule11)
        {

            fakeMove11 = "selected";
            molecule1.GetComponent<moleculeSelectionFake>().movingButton1 = "";
            molecule2.GetComponent<moleculeSelectionFake>().movingButton2 = "";
            molecule3.GetComponent<moleculeSelectionFake>().movingButton3 = "";

            //fakeMolecule12.GetComponent<moleculeSelectionFake>().fakeMove12 = "";
            fakeMolecule21.GetComponent<moleculeSelectionFake>().fakeMove21 = "";
            //fakeMolecule22.GetComponent<moleculeSelectionFake>().fakeMove22 = "";
            //fakeMolecule31.GetComponent<moleculeSelectionFake>().fakeMove31 = "";
            //fakeMolecule32.GetComponent<moleculeSelectionFake>().fakeMove32 = "";

            molecule1.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
            molecule2.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
            molecule3.gameObject.GetComponent<SpriteRenderer>().color = oldColour;

            fakeMolecule11.gameObject.GetComponent<SpriteRenderer>().color = selectedColour;
            //fakeMolecule12.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
            fakeMolecule21.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
            //fakeMolecule22.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
            //fakeMolecule31.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
            //fakeMolecule32.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        }

        //else if (this.gameObject == fakeMolecule12)
        //{
            
        //    fakeMove12 = "selected";
        //    molecule1.GetComponent<moleculeSelectionFake>().movingButton1 = "";
        //    molecule2.GetComponent<moleculeSelectionFake>().movingButton2 = "";
        //    molecule3.GetComponent<moleculeSelectionFake>().movingButton3 = "";

        //    fakeMolecule11.GetComponent<moleculeSelectionFake>().fakeMove11 = "";
        //    fakeMolecule21.GetComponent<moleculeSelectionFake>().fakeMove21 = "";
        //    fakeMolecule22.GetComponent<moleculeSelectionFake>().fakeMove22 = "";
        //    fakeMolecule31.GetComponent<moleculeSelectionFake>().fakeMove31 = "";
        //    fakeMolecule32.GetComponent<moleculeSelectionFake>().fakeMove32 = "";

        //    molecule1.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //    molecule2.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //    molecule3.gameObject.GetComponent<SpriteRenderer>().color = oldColour;

        //    fakeMolecule12.gameObject.GetComponent<SpriteRenderer>().color = selectedColour;
        //    fakeMolecule11.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //    fakeMolecule21.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //    fakeMolecule22.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //    fakeMolecule31.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //    fakeMolecule32.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //}

        else if (this.gameObject == fakeMolecule21)
        {

            fakeMove21 = "selected";
            molecule1.GetComponent<moleculeSelectionFake>().movingButton1 = "";
            molecule2.GetComponent<moleculeSelectionFake>().movingButton2 = "";
            molecule3.GetComponent<moleculeSelectionFake>().movingButton3 = "";

            //fakeMolecule12.GetComponent<moleculeSelectionFake>().fakeMove12 = "";
            fakeMolecule11.GetComponent<moleculeSelectionFake>().fakeMove11 = "";
            //fakeMolecule22.GetComponent<moleculeSelectionFake>().fakeMove22 = "";
            //fakeMolecule31.GetComponent<moleculeSelectionFake>().fakeMove31 = "";
            //fakeMolecule32.GetComponent<moleculeSelectionFake>().fakeMove32 = "";

            molecule1.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
            molecule2.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
            molecule3.gameObject.GetComponent<SpriteRenderer>().color = oldColour;

            fakeMolecule21.gameObject.GetComponent<SpriteRenderer>().color = selectedColour;
            //fakeMolecule12.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
            fakeMolecule11.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
            //fakeMolecule22.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
            //fakeMolecule31.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
            //fakeMolecule32.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        }

        //else if (this.gameObject == fakeMolecule22)
        //{

        //    fakeMove22 = "selected";
        //    molecule1.GetComponent<moleculeSelectionFake>().movingButton1 = "";
        //    molecule2.GetComponent<moleculeSelectionFake>().movingButton2 = "";
        //    molecule3.GetComponent<moleculeSelectionFake>().movingButton3 = "";

        //    fakeMolecule12.GetComponent<moleculeSelectionFake>().fakeMove12 = "";
        //    fakeMolecule21.GetComponent<moleculeSelectionFake>().fakeMove21 = "";
        //    fakeMolecule11.GetComponent<moleculeSelectionFake>().fakeMove11 = "";
        //    fakeMolecule31.GetComponent<moleculeSelectionFake>().fakeMove31 = "";
        //    fakeMolecule32.GetComponent<moleculeSelectionFake>().fakeMove32 = "";

        //    molecule1.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //    molecule2.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //    molecule3.gameObject.GetComponent<SpriteRenderer>().color = oldColour;

        //    fakeMolecule22.gameObject.GetComponent<SpriteRenderer>().color = selectedColour;
        //    fakeMolecule12.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //    fakeMolecule21.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //    fakeMolecule11.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //    fakeMolecule31.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //    fakeMolecule32.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //}

        //else if (this.gameObject == fakeMolecule31)
        //{

        //    fakeMove31 = "selected";
        //    molecule1.GetComponent<moleculeSelectionFake>().movingButton1 = "";
        //    molecule2.GetComponent<moleculeSelectionFake>().movingButton2 = "";
        //    molecule3.GetComponent<moleculeSelectionFake>().movingButton3 = "";

        //    fakeMolecule12.GetComponent<moleculeSelectionFake>().fakeMove12 = "";
        //    fakeMolecule21.GetComponent<moleculeSelectionFake>().fakeMove21 = "";
        //    fakeMolecule22.GetComponent<moleculeSelectionFake>().fakeMove22 = "";
        //    fakeMolecule11.GetComponent<moleculeSelectionFake>().fakeMove11 = "";
        //    fakeMolecule32.GetComponent<moleculeSelectionFake>().fakeMove32 = "";

        //    molecule1.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //    molecule2.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //    molecule3.gameObject.GetComponent<SpriteRenderer>().color = oldColour;

        //    fakeMolecule31.gameObject.GetComponent<SpriteRenderer>().color = selectedColour;
        //    fakeMolecule12.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //    fakeMolecule21.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //    fakeMolecule22.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //    fakeMolecule11.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //    fakeMolecule32.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //}

        //else if (this.gameObject == fakeMolecule32)
        //{

        //    fakeMove32 = "selected";
        //    molecule1.GetComponent<moleculeSelectionFake>().movingButton1 = "";
        //    molecule2.GetComponent<moleculeSelectionFake>().movingButton2 = "";
        //    molecule3.GetComponent<moleculeSelectionFake>().movingButton3 = "";

        //    fakeMolecule12.GetComponent<moleculeSelectionFake>().fakeMove12 = "";
        //    fakeMolecule21.GetComponent<moleculeSelectionFake>().fakeMove21 = "";
        //    fakeMolecule22.GetComponent<moleculeSelectionFake>().fakeMove22 = "";
        //    fakeMolecule31.GetComponent<moleculeSelectionFake>().fakeMove31 = "";
        //    fakeMolecule11.GetComponent<moleculeSelectionFake>().fakeMove11 = "";

        //    molecule1.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //    molecule2.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //    molecule3.gameObject.GetComponent<SpriteRenderer>().color = oldColour;

        //    fakeMolecule32.gameObject.GetComponent<SpriteRenderer>().color = selectedColour;
        //    fakeMolecule12.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //    fakeMolecule21.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //    fakeMolecule22.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //    fakeMolecule31.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //    fakeMolecule11.gameObject.GetComponent<SpriteRenderer>().color = oldColour;
        //}


        /////
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class equationBoxFake : MonoBehaviour {

    public GameObject firstSlot;
    public GameObject secondSlot;
    public GameObject thirdSlot;

    public GameObject molecule1;
    public GameObject molecule2;
    public GameObject molecule3;

    public GameObject fakeMolecule11;
    //public GameObject fakeMolecule12;
    public GameObject fakeMolecule21;
    //public GameObject fakeMolecule22;
    //public GameObject fakeMolecule31;
    //public GameObject fakeMolecule32;

    public GameObject key;
    public GameObject glowyDoor;
    public GameObject openDoor;
    public GameObject wrongEqnMsg;

    public string slotButton1;
    public string slotButton2;
    public string slotButton3;

    public Sprite firstMolecule;
    public Sprite secondMolecule;
    public Sprite thirdMolecule;

    public Sprite fakeSprite11;
    //public Sprite fakeSprite12;
    public Sprite fakeSprite21;
    //public Sprite fakeSprite22;
    //public Sprite fakeSprite31;
    //public Sprite fakeSprite32;

    public Sprite transparentSprite;

    private Color oldColour;

    public void Start()
    {
        key.SetActive(false);
        openDoor.SetActive(false);
        wrongEqnMsg.SetActive(false);
        glowyDoor.SetActive(false);
        oldColour = new Color(1f, 1f, 1f, 1f);
    }

    private void OnMouseDown()
    {
        if (this.gameObject == firstSlot && firstSlot.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        {
            slotButton1 = "selected";
            //secondSlot.GetComponent<equationBox>().slotButton2 = "";
            //thirdSlot.GetComponent<equationBox>().slotButton3 = "";
        }

        else if (this.gameObject == secondSlot && secondSlot.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        {
            slotButton2 = "selected";
            //firstSlot.GetComponent<equationBox>().slotButton1 = "";
            //thirdSlot.GetComponent<equationBox>().slotButton3 = "";
        }
        else if (this.gameObject == thirdSlot && thirdSlot.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        {
            slotButton3 = "selected";
        }
        else if (this.gameObject == firstSlot && firstSlot.GetComponent<equationBoxFake>().slotButton1 == "selected")
        {
            slotButton1 = "selected2";
        }
        else if (this.gameObject == secondSlot && secondSlot.GetComponent<equationBoxFake>().slotButton2 == "selected")
        {
            slotButton2 = "selected2";
        }
        else if (this.gameObject == thirdSlot && thirdSlot.GetComponent<equationBoxFake>().slotButton3 == "selected")
        {
            slotButton3 = "selected2";
        }

        moveMolecule();
        returnMolecule();
        gameOver();
        wrongEqn();
    }

    private void moveMolecule()
    {
        if (slotButton1 == "selected" && molecule1.GetComponent<moleculeSelectionFake>().movingButton1 == "selected" 
            && firstSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        {
            Debug.Log("moved!");
            firstSlot.transform.GetComponent<SpriteRenderer>().sprite = firstMolecule;
            molecule1.SetActive(false);
            molecule1.GetComponent<moleculeSelectionFake>().movingButton1 = "";
            molecule1.GetComponent<SpriteRenderer>().color = oldColour;

        }

        else if (slotButton1 == "selected" && molecule2.GetComponent<moleculeSelectionFake>().movingButton2 == "selected" 
                 && firstSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        {
            firstSlot.transform.GetComponent<SpriteRenderer>().sprite = secondMolecule;
            molecule2.SetActive(false);
            molecule2.GetComponent<moleculeSelectionFake>().movingButton2 = "";
            molecule2.GetComponent<SpriteRenderer>().color = oldColour;
        }

        else if (slotButton1 == "selected" && molecule3.GetComponent<moleculeSelectionFake>().movingButton3 == "selected" 
                 && firstSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        {
            firstSlot.transform.GetComponent<SpriteRenderer>().sprite = thirdMolecule;
            molecule3.SetActive(false);
            molecule3.GetComponent<moleculeSelectionFake>().movingButton3 = "";
            molecule3.GetComponent<SpriteRenderer>().color = oldColour;
        }

        else if (slotButton2 == "selected" && molecule1.GetComponent<moleculeSelectionFake>().movingButton1 == "selected" 
                 && secondSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        {
            secondSlot.transform.GetComponent<SpriteRenderer>().sprite = firstMolecule;
            molecule1.SetActive(false);
            molecule1.GetComponent<moleculeSelectionFake>().movingButton1 = "";
            molecule1.GetComponent<SpriteRenderer>().color = oldColour;
        }

        else if (slotButton2 == "selected" && molecule2.GetComponent<moleculeSelectionFake>().movingButton2 == "selected" 
                 && secondSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        {
            secondSlot.transform.GetComponent<SpriteRenderer>().sprite = secondMolecule;
            molecule2.SetActive(false);
            molecule2.GetComponent<moleculeSelectionFake>().movingButton2 = "";
            molecule2.GetComponent<SpriteRenderer>().color = oldColour;
        }

        else if (slotButton2 == "selected" && molecule3.GetComponent<moleculeSelectionFake>().movingButton3 == "selected" 
                 && secondSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        {
            secondSlot.transform.GetComponent<SpriteRenderer>().sprite = thirdMolecule;
            molecule3.SetActive(false);
            molecule3.GetComponent<moleculeSelectionFake>().movingButton3 = "";
            molecule3.GetComponent<SpriteRenderer>().color = oldColour;
        }

        else if (slotButton3 == "selected" && molecule1.GetComponent<moleculeSelectionFake>().movingButton1 == "selected" 
                 && thirdSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        {
            thirdSlot.transform.GetComponent<SpriteRenderer>().sprite = firstMolecule;
            molecule1.SetActive(false);
            molecule1.GetComponent<moleculeSelectionFake>().movingButton1 = "";
            molecule1.GetComponent<SpriteRenderer>().color = oldColour;
        }

        else if (slotButton3 == "selected" && molecule2.GetComponent<moleculeSelectionFake>().movingButton2 == "selected" 
                 && thirdSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        {
            thirdSlot.transform.GetComponent<SpriteRenderer>().sprite = secondMolecule;
            molecule2.SetActive(false);
            molecule2.GetComponent<moleculeSelectionFake>().movingButton2 = "";
            molecule2.GetComponent<SpriteRenderer>().color = oldColour;
        }

        else if (slotButton3 == "selected" && molecule3.GetComponent<moleculeSelectionFake>().movingButton3 == "selected" 
                 && thirdSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        {
            thirdSlot.transform.GetComponent<SpriteRenderer>().sprite = thirdMolecule;
            molecule3.SetActive(false);
            molecule3.GetComponent<moleculeSelectionFake>().movingButton3 = "";
            molecule3.GetComponent<SpriteRenderer>().color = oldColour;
        }

        else if (slotButton1 == "selected" && fakeMolecule11.GetComponent<moleculeSelectionFake>().fakeMove11 == "selected" 
                 && firstSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        {
            firstSlot.transform.GetComponent<SpriteRenderer>().sprite = fakeSprite11;
            fakeMolecule11.SetActive(false);
            fakeMolecule11.GetComponent<moleculeSelectionFake>().fakeMove11 = "";
            fakeMolecule11.GetComponent<SpriteRenderer>().color = oldColour;
        }

        //else if (slotButton1 == "selected" && fakeMolecule12.GetComponent<moleculeSelectionFake>().fakeMove12 == "selected" 
        //         && firstSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        //{
        //    firstSlot.transform.GetComponent<SpriteRenderer>().sprite = fakeSprite12;
        //    fakeMolecule12.SetActive(false);
        //    fakeMolecule12.GetComponent<moleculeSelectionFake>().fakeMove12 = "";
        //    fakeMolecule12.GetComponent<SpriteRenderer>().color = oldColour;
        //}

        else if (slotButton1 == "selected" && fakeMolecule21.GetComponent<moleculeSelectionFake>().fakeMove21 == "selected" 
                 && firstSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        {
            firstSlot.transform.GetComponent<SpriteRenderer>().sprite = fakeSprite21;
            fakeMolecule21.SetActive(false);
            fakeMolecule21.GetComponent<moleculeSelectionFake>().fakeMove21 = "";
            fakeMolecule21.GetComponent<SpriteRenderer>().color = oldColour;
        }

        //else if (slotButton1 == "selected" && fakeMolecule22.GetComponent<moleculeSelectionFake>().fakeMove22 == "selected" 
        //         && firstSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        //{
        //    firstSlot.transform.GetComponent<SpriteRenderer>().sprite = fakeSprite22;
        //    fakeMolecule22.SetActive(false);
        //    fakeMolecule22.GetComponent<moleculeSelectionFake>().fakeMove22 = "";
        //    fakeMolecule22.GetComponent<SpriteRenderer>().color = oldColour;
        //}

        //else if (slotButton1 == "selected" && fakeMolecule31.GetComponent<moleculeSelectionFake>().fakeMove31 == "selected" 
        //         && firstSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        //{
        //    firstSlot.transform.GetComponent<SpriteRenderer>().sprite = fakeSprite31;
        //    fakeMolecule31.SetActive(false);
        //    fakeMolecule31.GetComponent<moleculeSelectionFake>().fakeMove31 = "";
        //    fakeMolecule31.GetComponent<SpriteRenderer>().color = oldColour;
        //}

        //else if (slotButton1 == "selected" && fakeMolecule32.GetComponent<moleculeSelectionFake>().fakeMove32 == "selected" 
        //         && firstSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        //{
        //    firstSlot.transform.GetComponent<SpriteRenderer>().sprite = fakeSprite32;
        //    fakeMolecule32.SetActive(false);
        //    fakeMolecule32.GetComponent<moleculeSelectionFake>().fakeMove32 = "";
        //    fakeMolecule32.GetComponent<SpriteRenderer>().color = oldColour;
        //}

        else if (slotButton2 == "selected" && fakeMolecule11.GetComponent<moleculeSelectionFake>().fakeMove11 == "selected" 
                 && secondSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        {
            secondSlot.transform.GetComponent<SpriteRenderer>().sprite = fakeSprite11;
            fakeMolecule11.SetActive(false);
            fakeMolecule11.GetComponent<moleculeSelectionFake>().fakeMove11 = "";
            fakeMolecule11.GetComponent<SpriteRenderer>().color = oldColour;
        }

        //else if (slotButton2 == "selected" && fakeMolecule12.GetComponent<moleculeSelectionFake>().fakeMove12 == "selected" 
        //         && secondSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        //{
        //    secondSlot.transform.GetComponent<SpriteRenderer>().sprite = fakeSprite12;
        //    fakeMolecule12.SetActive(false);
        //    fakeMolecule12.GetComponent<moleculeSelectionFake>().fakeMove12 = "";
        //    fakeMolecule12.GetComponent<SpriteRenderer>().color = oldColour;
        //}

        else if (slotButton2 == "selected" && fakeMolecule21.GetComponent<moleculeSelectionFake>().fakeMove21 == "selected" 
                 && secondSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        {
            secondSlot.transform.GetComponent<SpriteRenderer>().sprite = fakeSprite21;
            fakeMolecule21.SetActive(false);
            fakeMolecule21.GetComponent<moleculeSelectionFake>().fakeMove11 = "";
            fakeMolecule21.GetComponent<SpriteRenderer>().color = oldColour;
        }

        //else if (slotButton2 == "selected" && fakeMolecule22.GetComponent<moleculeSelectionFake>().fakeMove22 == "selected" 
        //         && secondSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        //{
        //    secondSlot.transform.GetComponent<SpriteRenderer>().sprite = fakeSprite22;
        //    fakeMolecule22.SetActive(false);
        //    fakeMolecule22.GetComponent<moleculeSelectionFake>().fakeMove11 = "";
        //    fakeMolecule22.GetComponent<SpriteRenderer>().color = oldColour;
        //}

        //else if (slotButton2 == "selected" && fakeMolecule31.GetComponent<moleculeSelectionFake>().fakeMove31 == "selected" 
        //         && secondSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        //{
        //    secondSlot.transform.GetComponent<SpriteRenderer>().sprite = fakeSprite31;
        //    fakeMolecule31.SetActive(false);
        //    fakeMolecule31.GetComponent<moleculeSelectionFake>().fakeMove31 = "";
        //    fakeMolecule31.GetComponent<SpriteRenderer>().color = oldColour;
        //}

        //else if (slotButton2 == "selected" && fakeMolecule32.GetComponent<moleculeSelectionFake>().fakeMove32 == "selected" 
        //         && secondSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        //{
        //    secondSlot.transform.GetComponent<SpriteRenderer>().sprite = fakeSprite32;
        //    fakeMolecule32.SetActive(false);
        //    fakeMolecule32.GetComponent<moleculeSelectionFake>().fakeMove11 = "";
        //    fakeMolecule32.GetComponent<SpriteRenderer>().color = oldColour;
        //}

        else if (slotButton3 == "selected" && fakeMolecule11.GetComponent<moleculeSelectionFake>().fakeMove11 == "selected" 
                 && thirdSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        {
            thirdSlot.transform.GetComponent<SpriteRenderer>().sprite = fakeSprite11;
            fakeMolecule11.SetActive(false);
            fakeMolecule11.GetComponent<moleculeSelectionFake>().fakeMove11 = "";
            fakeMolecule11.GetComponent<SpriteRenderer>().color = oldColour;
        }

        //else if (slotButton3 == "selected" && fakeMolecule12.GetComponent<moleculeSelectionFake>().fakeMove12 == "selected" 
        //         && thirdSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        //{
        //    thirdSlot.transform.GetComponent<SpriteRenderer>().sprite = fakeSprite12;
        //    fakeMolecule12.SetActive(false);
        //    fakeMolecule12.GetComponent<moleculeSelectionFake>().fakeMove12 = "";
        //    fakeMolecule12.GetComponent<SpriteRenderer>().color = oldColour;
        //}

        else if (slotButton3 == "selected" && fakeMolecule21.GetComponent<moleculeSelectionFake>().fakeMove21 == "selected" 
                 && thirdSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        {
            thirdSlot.transform.GetComponent<SpriteRenderer>().sprite = fakeSprite21;
            fakeMolecule21.SetActive(false);
            fakeMolecule21.GetComponent<moleculeSelectionFake>().fakeMove21 = "";
            fakeMolecule21.GetComponent<SpriteRenderer>().color = oldColour;
        }

        //else if (slotButton3 == "selected" && fakeMolecule22.GetComponent<moleculeSelectionFake>().fakeMove22 == "selected" 
        //         && thirdSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        //{
        //    thirdSlot.transform.GetComponent<SpriteRenderer>().sprite = fakeSprite22;
        //    fakeMolecule22.SetActive(false);
        //    fakeMolecule22.GetComponent<moleculeSelectionFake>().fakeMove22 = "";
        //    fakeMolecule22.GetComponent<SpriteRenderer>().color = oldColour;
        //}

        //else if (slotButton3 == "selected" && fakeMolecule31.GetComponent<moleculeSelectionFake>().fakeMove31 == "selected" 
        //         && thirdSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        //{
        //    thirdSlot.transform.GetComponent<SpriteRenderer>().sprite = fakeSprite31;
        //    fakeMolecule31.SetActive(false);
        //    fakeMolecule31.GetComponent<moleculeSelectionFake>().fakeMove31 = "";
        //    fakeMolecule31.GetComponent<SpriteRenderer>().color = oldColour;
        //}

        //else if (slotButton3 == "selected" && fakeMolecule32.GetComponent<moleculeSelectionFake>().fakeMove32 == "selected" 
        //         && thirdSlot.transform.GetComponent<SpriteRenderer>().sprite == transparentSprite)
        //{
        //    thirdSlot.transform.GetComponent<SpriteRenderer>().sprite = fakeSprite32;
        //    fakeMolecule32.SetActive(false);
        //    fakeMolecule32.GetComponent<moleculeSelectionFake>().fakeMove32 = "";
        //    fakeMolecule32.GetComponent<SpriteRenderer>().color = oldColour;
        //}

    }

    private void returnMolecule()
    {
        if (firstSlot.GetComponent<equationBoxFake>().slotButton1 == "selected2" 
            && firstSlot.transform.GetComponent<SpriteRenderer>().sprite == firstMolecule)
        {
            Debug.Log("yay");
            firstSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
            molecule1.SetActive(true);
        }

        else if (firstSlot.GetComponent<equationBoxFake>().slotButton1 == "selected2" 
                 && firstSlot.transform.GetComponent<SpriteRenderer>().sprite == secondMolecule)
        {
            firstSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
            molecule2.SetActive(true);
        }

        else if (firstSlot.GetComponent<equationBoxFake>().slotButton1 == "selected2" 
                 && firstSlot.transform.GetComponent<SpriteRenderer>().sprite == thirdMolecule)
        {
            firstSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
            molecule3.SetActive(true);
        }

        else if (secondSlot.GetComponent<equationBoxFake>().slotButton2 == "selected2" 
                 && secondSlot.transform.GetComponent<SpriteRenderer>().sprite == firstMolecule)
        {
            secondSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
            molecule1.SetActive(true);
        }

        else if (secondSlot.GetComponent<equationBoxFake>().slotButton2 == "selected2" 
                 && secondSlot.transform.GetComponent<SpriteRenderer>().sprite == secondMolecule)
        {
            secondSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
            molecule2.SetActive(true);
        }

        else if (secondSlot.GetComponent<equationBoxFake>().slotButton2 == "selected2" 
                 && secondSlot.transform.GetComponent<SpriteRenderer>().sprite == thirdMolecule)
        {
            secondSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
            molecule3.SetActive(true);
        }

        else if (thirdSlot.GetComponent<equationBoxFake>().slotButton3 == "selected2" 
                 && thirdSlot.transform.GetComponent<SpriteRenderer>().sprite == firstMolecule)
        {
            thirdSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
            molecule1.SetActive(true);
        }

        else if (thirdSlot.GetComponent<equationBoxFake>().slotButton3 == "selected2" 
                 && thirdSlot.transform.GetComponent<SpriteRenderer>().sprite == secondMolecule)
        {
            thirdSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
            molecule2.SetActive(true);
        }

        else if (thirdSlot.GetComponent<equationBoxFake>().slotButton3 == "selected2" 
                 && thirdSlot.transform.GetComponent<SpriteRenderer>().sprite == thirdMolecule)
        {
            thirdSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
            molecule3.SetActive(true);
        }

        else if (firstSlot.GetComponent<equationBoxFake>().slotButton1 == "selected2" 
                 && firstSlot.transform.GetComponent<SpriteRenderer>().sprite == fakeSprite11)
        {
            firstSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
            fakeMolecule11.SetActive(true);
        }

        //else if (firstSlot.GetComponent<equationBoxFake>().slotButton1 == "selected2" 
        //         && firstSlot.transform.GetComponent<SpriteRenderer>().sprite == fakeSprite12)
        //{
        //    firstSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
        //    fakeMolecule12.SetActive(true);
        //}

        else if (firstSlot.GetComponent<equationBoxFake>().slotButton1 == "selected2" 
                 && firstSlot.transform.GetComponent<SpriteRenderer>().sprite == fakeSprite21)
        {
            firstSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
            fakeMolecule21.SetActive(true);
        }

        //else if (firstSlot.GetComponent<equationBoxFake>().slotButton1 == "selected2"
        //        && firstSlot.transform.GetComponent<SpriteRenderer>().sprite == fakeSprite22)
        //{
        //    firstSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
        //    fakeMolecule22.SetActive(true);
        //}
        //else if (firstSlot.GetComponent<equationBoxFake>().slotButton1 == "selected2"
        //        && firstSlot.transform.GetComponent<SpriteRenderer>().sprite == fakeSprite31)
        //{
        //    firstSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
        //    fakeMolecule31.SetActive(true);
        //}

        //else if (firstSlot.GetComponent<equationBoxFake>().slotButton1 == "selected2"
        //        && firstSlot.transform.GetComponent<SpriteRenderer>().sprite == fakeSprite32)
        //{
        //    firstSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
        //    fakeMolecule32.SetActive(true);
        //}

        else if (secondSlot.GetComponent<equationBoxFake>().slotButton2 == "selected2"
                 && secondSlot.transform.GetComponent<SpriteRenderer>().sprite == fakeSprite11)
        {
            secondSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
            fakeMolecule11.SetActive(true);
        }

        //else if (secondSlot.GetComponent<equationBoxFake>().slotButton2 == "selected2"
        //         && secondSlot.transform.GetComponent<SpriteRenderer>().sprite == fakeSprite12)
        //{
        //    secondSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
        //    fakeMolecule12.SetActive(true);
        //}

        else if (secondSlot.GetComponent<equationBoxFake>().slotButton2 == "selected2"
                 && secondSlot.transform.GetComponent<SpriteRenderer>().sprite == fakeSprite21)
        {
            secondSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
            fakeMolecule21.SetActive(true);
        }

        //else if (secondSlot.GetComponent<equationBoxFake>().slotButton2 == "selected2"
        //         && secondSlot.transform.GetComponent<SpriteRenderer>().sprite == fakeSprite22)
        //{
        //    secondSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
        //    fakeMolecule22.SetActive(true);
        //}

        //else if (secondSlot.GetComponent<equationBoxFake>().slotButton2 == "selected2"
        //         && secondSlot.transform.GetComponent<SpriteRenderer>().sprite == fakeSprite31)
        //{
        //    secondSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
        //    fakeMolecule31.SetActive(true);
        //}

        //else if (secondSlot.GetComponent<equationBoxFake>().slotButton2 == "selected2"
        //         && secondSlot.transform.GetComponent<SpriteRenderer>().sprite == fakeSprite32)
        //{
        //    secondSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
        //    fakeMolecule32.SetActive(true);
        //}

        else if (thirdSlot.GetComponent<equationBoxFake>().slotButton3 == "selected2"
                 && thirdSlot.transform.GetComponent<SpriteRenderer>().sprite == fakeSprite11)
        {
            thirdSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
            fakeMolecule11.SetActive(true);
        }

        //else if (thirdSlot.GetComponent<equationBoxFake>().slotButton3 == "selected2"
        //         && thirdSlot.transform.GetComponent<SpriteRenderer>().sprite == fakeSprite12)
        //{
        //    thirdSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
        //    fakeMolecule12.SetActive(true);
        //}

        else if (thirdSlot.GetComponent<equationBoxFake>().slotButton3 == "selected2"
                 && thirdSlot.transform.GetComponent<SpriteRenderer>().sprite == fakeSprite21)
        {
            thirdSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
            fakeMolecule21.SetActive(true);
        }

        //else if (thirdSlot.GetComponent<equationBoxFake>().slotButton3 == "selected2"
        //         && thirdSlot.transform.GetComponent<SpriteRenderer>().sprite == fakeSprite22)
        //{
        //    thirdSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
        //    fakeMolecule22.SetActive(true);
        //}

        //else if (thirdSlot.GetComponent<equationBoxFake>().slotButton3 == "selected2"
        //         && thirdSlot.transform.GetComponent<SpriteRenderer>().sprite == fakeSprite31)
        //{
        //    thirdSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
        //    fakeMolecule31.SetActive(true);
        //}

        //else if (thirdSlot.GetComponent<equationBoxFake>().slotButton3 == "selected2"
        //         && thirdSlot.transform.GetComponent<SpriteRenderer>().sprite == fakeSprite32)
        //{
        //    thirdSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
        //    fakeMolecule32.SetActive(true);
        //}
    }

    private void gameOver()
    {
        if ((firstSlot.transform.GetComponent<SpriteRenderer>().sprite == firstMolecule 
             || firstSlot.transform.GetComponent<SpriteRenderer>().sprite == secondMolecule) && 
            (secondSlot.transform.GetComponent<SpriteRenderer>().sprite == firstMolecule 
             || secondSlot.transform.GetComponent<SpriteRenderer>().sprite == secondMolecule) && 
            (thirdSlot.transform.GetComponent<SpriteRenderer>().sprite == thirdMolecule))
        {
            key.SetActive(true);
            glowyDoor.SetActive(true);

            Destroy(fakeMolecule11);
            //Destroy(fakeMolecule12);
            Destroy(fakeMolecule21);
            //Destroy(fakeMolecule22);
            //Destroy(fakeMolecule31);
            //Destroy(fakeMolecule32);

        }
    }

    private void wrongEqn()
    {   
        if (firstSlot.transform.GetComponent<SpriteRenderer>().sprite != transparentSprite 
            && secondSlot.transform.GetComponent<SpriteRenderer>().sprite != transparentSprite && 
            thirdSlot.transform.GetComponent<SpriteRenderer>().sprite != transparentSprite)
        {
            if (!((firstSlot.transform.GetComponent<SpriteRenderer>().sprite == firstMolecule 
                   || firstSlot.transform.GetComponent<SpriteRenderer>().sprite == secondMolecule) &&
           (secondSlot.transform.GetComponent<SpriteRenderer>().sprite == firstMolecule 
            || secondSlot.transform.GetComponent<SpriteRenderer>().sprite == secondMolecule) &&
            (thirdSlot.transform.GetComponent<SpriteRenderer>().sprite == thirdMolecule)))
            {
                Debug.Log("wrongeqn working!");
                wrongEqnMsg.SetActive(true);
            }
            
        }
       
    }

}

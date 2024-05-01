using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class equationBox : MonoBehaviour {

    public GameObject firstSlot;
    public GameObject secondSlot;
    public GameObject thirdSlot;

    public GameObject molecule1;
    public GameObject molecule2;
    public GameObject molecule3;

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
        else if (this.gameObject == firstSlot && firstSlot.GetComponent<equationBox>().slotButton1 == "selected")
        {
            slotButton1 = "selected2";
        }
        else if (this.gameObject == secondSlot && secondSlot.GetComponent<equationBox>().slotButton2 == "selected")
        {
            slotButton2 = "selected2";
        }
        else if (this.gameObject == thirdSlot && thirdSlot.GetComponent<equationBox>().slotButton3 == "selected")
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
        if (slotButton1 == "selected" && molecule1.GetComponent<moleculeSelection>().movingButton1 == "selected" && firstSlot.transform.GetComponent<SpriteRenderer>().sprite.name == "transparentSprite")
        {
            Debug.Log("moved!");
            firstSlot.transform.GetComponent<SpriteRenderer>().sprite = firstMolecule;
            molecule1.SetActive(false);
            molecule1.GetComponent<moleculeSelection>().movingButton1 = "";
            molecule1.GetComponent<SpriteRenderer>().color = oldColour;

        }

        else if (slotButton1 == "selected" && molecule2.GetComponent<moleculeSelection>().movingButton2 == "selected" && firstSlot.transform.GetComponent<SpriteRenderer>().sprite.name == "transparentSprite")
        {
            firstSlot.transform.GetComponent<SpriteRenderer>().sprite = secondMolecule;
            molecule2.SetActive(false);
            molecule2.GetComponent<moleculeSelection>().movingButton2 = "";
            molecule2.GetComponent<SpriteRenderer>().color = oldColour;
        }

        else if (slotButton1 == "selected" && molecule3.GetComponent<moleculeSelection>().movingButton3 == "selected" && firstSlot.transform.GetComponent<SpriteRenderer>().sprite.name == "transparentSprite")
        {
            firstSlot.transform.GetComponent<SpriteRenderer>().sprite = thirdMolecule;
            molecule3.SetActive(false);
            molecule3.GetComponent<moleculeSelection>().movingButton3 = "";
            molecule3.GetComponent<SpriteRenderer>().color = oldColour;
        }

        else if (slotButton2 == "selected" && molecule1.GetComponent<moleculeSelection>().movingButton1 == "selected" && secondSlot.transform.GetComponent<SpriteRenderer>().sprite.name == "transparentSprite")
        {
            secondSlot.transform.GetComponent<SpriteRenderer>().sprite = firstMolecule;
            molecule1.SetActive(false);
            molecule1.GetComponent<moleculeSelection>().movingButton1 = "";
            molecule1.GetComponent<SpriteRenderer>().color = oldColour;
        }

        else if (slotButton2 == "selected" && molecule2.GetComponent<moleculeSelection>().movingButton2 == "selected" && secondSlot.transform.GetComponent<SpriteRenderer>().sprite.name == "transparentSprite")
        {
            secondSlot.transform.GetComponent<SpriteRenderer>().sprite = secondMolecule;
            molecule2.SetActive(false);
            molecule2.GetComponent<moleculeSelection>().movingButton2 = "";
            molecule2.GetComponent<SpriteRenderer>().color = oldColour;
        }

        else if (slotButton2 == "selected" && molecule3.GetComponent<moleculeSelection>().movingButton3 == "selected" && secondSlot.transform.GetComponent<SpriteRenderer>().sprite.name == "transparentSprite")
        {
            secondSlot.transform.GetComponent<SpriteRenderer>().sprite = thirdMolecule;
            molecule3.SetActive(false);
            molecule3.GetComponent<moleculeSelection>().movingButton3 = "";
            molecule3.GetComponent<SpriteRenderer>().color = oldColour;
        }

        else if (slotButton3 == "selected" && molecule1.GetComponent<moleculeSelection>().movingButton1 == "selected" && thirdSlot.transform.GetComponent<SpriteRenderer>().sprite.name == "transparentSprite")
        {
            thirdSlot.transform.GetComponent<SpriteRenderer>().sprite = firstMolecule;
            molecule1.SetActive(false);
            molecule1.GetComponent<moleculeSelection>().movingButton1 = "";
            molecule1.GetComponent<SpriteRenderer>().color = oldColour;
        }

        else if (slotButton3 == "selected" && molecule2.GetComponent<moleculeSelection>().movingButton2 == "selected" && thirdSlot.transform.GetComponent<SpriteRenderer>().sprite.name == "transparentSprite")
        {
            thirdSlot.transform.GetComponent<SpriteRenderer>().sprite = secondMolecule;
            molecule2.SetActive(false);
            molecule2.GetComponent<moleculeSelection>().movingButton2 = "";
            molecule2.GetComponent<SpriteRenderer>().color = oldColour;
        }

        else if (slotButton3 == "selected" && molecule3.GetComponent<moleculeSelection>().movingButton3 == "selected" && thirdSlot.transform.GetComponent<SpriteRenderer>().sprite.name == "transparentSprite")
        {
            thirdSlot.transform.GetComponent<SpriteRenderer>().sprite = thirdMolecule;
            molecule3.SetActive(false);
            molecule3.GetComponent<moleculeSelection>().movingButton3 = "";
            molecule3.GetComponent<SpriteRenderer>().color = oldColour;
        }

        //slotButton1 = "";
        //slotButton2 = "";
        //slotButton3 = "";
    }

    private void returnMolecule()
    {
        if (firstSlot.GetComponent<equationBox>().slotButton1 == "selected2" && firstSlot.transform.GetComponent<SpriteRenderer>().sprite == firstMolecule)
        {
            Debug.Log("yay");
            firstSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
            molecule1.SetActive(true);
        }

        else if (firstSlot.GetComponent<equationBox>().slotButton1 == "selected2" && firstSlot.transform.GetComponent<SpriteRenderer>().sprite == secondMolecule)
        {
            firstSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
            molecule2.SetActive(true);
        }

        else if (firstSlot.GetComponent<equationBox>().slotButton1 == "selected2" && firstSlot.transform.GetComponent<SpriteRenderer>().sprite == thirdMolecule)
        {
            firstSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
            molecule3.SetActive(true);
        }

        else if (secondSlot.GetComponent<equationBox>().slotButton2 == "selected2" && secondSlot.transform.GetComponent<SpriteRenderer>().sprite == firstMolecule)
        {
            secondSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
            molecule1.SetActive(true);
        }

        else if (secondSlot.GetComponent<equationBox>().slotButton2 == "selected2" && secondSlot.transform.GetComponent<SpriteRenderer>().sprite == secondMolecule)
        {
            secondSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
            molecule2.SetActive(true);
        }

        else if (secondSlot.GetComponent<equationBox>().slotButton2 == "selected2" && secondSlot.transform.GetComponent<SpriteRenderer>().sprite == thirdMolecule)
        {
            secondSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
            molecule3.SetActive(true);
        }

        else if (thirdSlot.GetComponent<equationBox>().slotButton3 == "selected2" && thirdSlot.transform.GetComponent<SpriteRenderer>().sprite == firstMolecule)
        {
            thirdSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
            molecule1.SetActive(true);
        }

        else if (thirdSlot.GetComponent<equationBox>().slotButton3 == "selected2" && thirdSlot.transform.GetComponent<SpriteRenderer>().sprite == secondMolecule)
        {
            thirdSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
            molecule2.SetActive(true);
        }

        else if (thirdSlot.GetComponent<equationBox>().slotButton3 == "selected2" && thirdSlot.transform.GetComponent<SpriteRenderer>().sprite == thirdMolecule)
        {
            thirdSlot.transform.GetComponent<SpriteRenderer>().sprite = transparentSprite;
            molecule3.SetActive(true);
        }
    }

    private void gameOver()
    {
        if ((firstSlot.transform.GetComponent<SpriteRenderer>().sprite == firstMolecule || firstSlot.transform.GetComponent<SpriteRenderer>().sprite == secondMolecule) && 
            (secondSlot.transform.GetComponent<SpriteRenderer>().sprite == firstMolecule || secondSlot.transform.GetComponent<SpriteRenderer>().sprite == secondMolecule) && 
            (thirdSlot.transform.GetComponent<SpriteRenderer>().sprite == thirdMolecule))
        {
            key.SetActive(true);
            glowyDoor.SetActive(true);
        }
    }

    private void wrongEqn()
    {   
        if (firstSlot.transform.GetComponent<SpriteRenderer>().sprite != transparentSprite && secondSlot.transform.GetComponent<SpriteRenderer>().sprite != transparentSprite && 
            thirdSlot.transform.GetComponent<SpriteRenderer>().sprite != transparentSprite)
        {
            if (!((firstSlot.transform.GetComponent<SpriteRenderer>().sprite == firstMolecule || firstSlot.transform.GetComponent<SpriteRenderer>().sprite == secondMolecule) &&
           (secondSlot.transform.GetComponent<SpriteRenderer>().sprite == firstMolecule || secondSlot.transform.GetComponent<SpriteRenderer>().sprite == secondMolecule) &&
            (thirdSlot.transform.GetComponent<SpriteRenderer>().sprite == thirdMolecule)))
            {
                Debug.Log("wrongeqn working!");
                wrongEqnMsg.SetActive(true);
            }
            
        }
       
    }

}

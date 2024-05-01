using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CombineButton : MonoBehaviour {

    private GameObject Mg1;
    private GameObject Mg2;
    private GameObject O1;
    private GameObject O2;
    private GameObject bottomPanel;

    public void Start()
    {
        Mg1 = GameObject.Find("Mg(1)");
        Mg2 = GameObject.Find("Mg(2)");
        O1 = GameObject.Find("O1");
        O2 = GameObject.Find("O2");
        bottomPanel = GameObject.Find("Bottom panel");
    }

    public void OnClickCombine()
    {
        Debug.Log("yes1");
        if (Mg1.transform.parent == bottomPanel)
        {
            Debug.Log("yey2");
        }
    }
}
//&& ((O1.transform.parent == bottomPanel && O2.transform.parent == bottomPanel) || (O1.transform.parent != bottomPanel && O2.transform.parent != bottomPanel))
//&& Mg2.transform.parent == bottomPanel
//Mg1.transform.parent == bottomPanel

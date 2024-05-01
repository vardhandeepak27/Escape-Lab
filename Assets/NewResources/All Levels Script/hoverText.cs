using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoverText : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
        GetComponent<Renderer>().sortingOrder = 3;
	}
	
	// Update is called once per frame
	void Update () {
		
        if (ItemTextControl.textstatus == "off")
        {
            Destroy(gameObject);
        }
	}
}

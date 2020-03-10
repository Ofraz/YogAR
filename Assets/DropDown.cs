using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class DropDown : MonoBehaviour {

    private Animator buttonAnim;
    private Boton boton;


	// Use this for initialization
	void Start () {
        buttonAnim = GetComponent<Animator>();
        boton = GameObject.Find("Code").GetComponent<Boton>();
	}
	
	// Update is called once per frame
	void Update () {
		if (boton.showMenu)
            buttonAnim.SetBool("b_showMenu", true);
        
        if(!boton.showMenu)
            buttonAnim.SetBool("b_showMenu", false);
    
    }
}

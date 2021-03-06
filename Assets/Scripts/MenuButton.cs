﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour {

    [SerializeField]
    private string panelToOpen;

    [SerializeField]
    private Sprite hover;
    private Sprite standard;

    SpriteRenderer sr;

    void Start () {
        if (GetComponent<SpriteRenderer>())
        {
            standard = GetComponent<SpriteRenderer>().sprite;
            sr = GetComponent<SpriteRenderer>();
        }
    }
	
	void Update () {
		
	}

    void OnMouseDown()
    {
        if(hover)
            sr.sprite = hover;
    }

    void OnMouseUp()
    {
        if(sr)
            sr.sprite = standard;

        if(panelToOpen == "left")
            FindObjectOfType<MoveCamera>().OpenLeftMenu();
        if (panelToOpen == "right")
            FindObjectOfType<MoveCamera>().OpenRightMenu();
        if (panelToOpen == "top")
            FindObjectOfType<MoveCamera>().OpenTopMenu();
        if (panelToOpen == "bottom")
            FindObjectOfType<MoveCamera>().OpenBottomMenu();
        if (panelToOpen == "main")
            FindObjectOfType<MoveCamera>().OpenMain();
        if (panelToOpen == "bottomleft")
            FindObjectOfType<MoveCamera>().OpenBottomLeft();
    }
}

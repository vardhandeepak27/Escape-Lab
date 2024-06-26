﻿using UnityEngine;
using System.Collections;

public class mouseCursor : MonoBehaviour
{

    //Otherwise you can do it publicly.  
    public Texture2D cursor;


    void OnMouseEnter()
    {
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
    }

    void OnMouseExit()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }

}
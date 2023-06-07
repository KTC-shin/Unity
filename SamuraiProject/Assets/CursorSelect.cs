using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorSelect : MonoBehaviour
{
    public Texture2D handCursorMaine;
    public Texture2D handCursorSab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Cursor.SetCursor(handCursorSab, Vector2.zero, CursorMode.Auto);
            Debug.Log("‚¨‚µ‚½");
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Cursor.SetCursor(handCursorMaine, Vector2.zero, CursorMode.Auto);
            Debug.Log("‚Í‚È‚µ‚½");
        }
    }
}
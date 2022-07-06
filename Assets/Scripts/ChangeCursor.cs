using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCursor : MonoBehaviour
{
    [SerializeField] private CursorType cursor, defaultCursor;

    private void OnMouseEnter()
    {
        Cursor.SetCursor(cursor.cursorTexture, cursor.cursorHotspot, CursorMode.Auto);
    }

    private void OnMouseExit()
    {
        Cursor.SetCursor(defaultCursor.cursorTexture, defaultCursor.cursorHotspot, CursorMode.Auto);
    }

}

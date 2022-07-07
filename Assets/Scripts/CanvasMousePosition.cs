using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RectTransformUtility;

public class CanvasMousePosition : MonoBehaviour
{
    private Canvas _mainCanvas;

    private void Awake()
    {
        _mainCanvas = GetComponent<Canvas>();
    }

    public Vector2 GetMousePositionInCanvas()
    {
        Vector2 localPosition = new Vector2();
        Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        if (ScreenPointToLocalPointInRectangle(_mainCanvas.GetComponent<RectTransform>(),
            screenPosition, Camera.main, out localPosition) == true)
        {
            return localPosition;
        }
        else return Vector2.zero;
    }
}

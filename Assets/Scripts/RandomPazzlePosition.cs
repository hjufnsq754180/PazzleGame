using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RandomPazzlePosition : MonoBehaviour
{
    private List<PazzlePiece> _pazzlePieces;

    private void Awake()
    {
        _pazzlePieces = GetComponentsInChildren<PazzlePiece>().ToList();
        RandomizePosition();
    }

    private void RandomizePosition()
    {
        foreach (var piece in _pazzlePieces)
        {
            int x1 = Random.Range(-800, -600);
            int x2 = Random.Range(600, 800);
            int y = Random.Range(-300, 300);

            int choiseSide = Random.Range(-10, 10);
            if (choiseSide >= 0)
            {
                piece.GetComponent<RectTransform>().transform.localPosition = new Vector2(x1, y);
            }
            else
            {
                piece.GetComponent<RectTransform>().transform.localPosition = new Vector2(x2, y);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PazzleList : MonoBehaviour
{
    private List<PazzlePiece> _pazzlePieces;
    [SerializeField]
    private int currentPieceId;

    private void Awake()
    {
        _pazzlePieces = GetComponentsInChildren<PazzlePiece>().ToList();
    }

    public bool IsSlotId(int slotId)
    {
        if (currentPieceId == slotId)
        {
            return true;
        }
        return false;
    }

    public void DisabledPiece(int slotId)
    {
        PazzlePiece piece = _pazzlePieces.Where(x => x.pazzleId == slotId).FirstOrDefault();
        piece.enabled = false;
    }

    public void SetCurrentId(int pieceId)
    {
        currentPieceId = pieceId;
    }

    public int GetPazzleCount()
    {
        return _pazzlePieces.Count;
    }
}

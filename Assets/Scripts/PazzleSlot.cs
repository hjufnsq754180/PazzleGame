using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

public class PazzleSlot : MonoBehaviour, IDropHandler
{
    public int pazzleSlotId;
    private PazzleList _pazzleList;
    private LevelCompleted _levelCompleted;

    [Inject]
    private void Construct(PazzleList pazzleList, LevelCompleted levelCompleted)
    {
        _pazzleList = pazzleList;
        _levelCompleted = levelCompleted;
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (_pazzleList.IsSlotId(pazzleSlotId))
        {
            Transform pazzlePieceTransform = eventData.pointerDrag.transform;
            pazzlePieceTransform.SetParent(transform);
            pazzlePieceTransform.localPosition = Vector3.zero;
            _pazzleList.DisabledPiece(pazzleSlotId);
            _levelCompleted.GainGridPiece();
        }
    }
}

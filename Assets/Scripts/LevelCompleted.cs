using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

public class LevelCompleted : MonoBehaviour
{
    [SerializeField]
    private GameObject _completePanel;
    private PazzleList _pazzList;
    [SerializeField]
    private int piece;
    [SerializeField]
    private int currentGridPiece = 0;

    [Inject]
    private void Construct(PazzleList pazzleList)
    {
        _pazzList = pazzleList;
    }

    private void Start()
    {
        piece = _pazzList.GetPazzleCount();
        _completePanel.SetActive(false);
    }

    public void PazzleCompleted()
    {
        PlayerPrefs.SetInt("CurrentCompleteLevel", SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("MainScene");
    }

    public void GainGridPiece()
    {
        currentGridPiece++;
        if (currentGridPiece == piece)
        {
            ShowCompletePanel();
        }
    }

    private void ShowCompletePanel()
    {
        _completePanel.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ActivationCompleteLevel : MonoBehaviour
{
    [SerializeField]
    private Button[] _levelButtons;

    private void OnEnable()
    {
        LoadPrefLevelCount();
    }

    private void Awake()
    {
        GetLevelButtons();
        SetFirstLevel();
    }

    private void SetFirstLevel()
    {
        if (!PlayerPrefs.HasKey("CurrentCompleteLevel"))
        {
            PlayerPrefs.SetInt("CurrentCompleteLevel", 1);
        }
    }

    private void GetLevelButtons()
    {
        _levelButtons = GetComponentsInChildren<Button>();
        DisableAllButtons();
    }

    private void DisableAllButtons()
    {
        for (int i = 0; i < _levelButtons.Length; i++)
        {
            _levelButtons[i].interactable = false;
        }
        LoadPrefLevelCount();
    }

    private void LoadPrefLevelCount()
    {
        if (PlayerPrefs.GetInt("CurrentCompleteLevel") < SceneManager.sceneCountInBuildSettings)
        {
            for (int i = 0; i < PlayerPrefs.GetInt("CurrentCompleteLevel"); i++)
            {
                _levelButtons[i].interactable = true;
            }
        }
        else
        {
            PlayerPrefs.SetInt("CurrentCompleteLevel", SceneManager.sceneCountInBuildSettings - 1);
        }
    }
}

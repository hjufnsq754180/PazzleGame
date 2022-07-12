using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class CurrentLanguage : MonoBehaviour
{
    private void Awake()
    {
        YandexGame.savesData.language = "ru";
    }
}

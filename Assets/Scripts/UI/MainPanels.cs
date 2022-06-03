using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPanels : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> panels;

    private void Awake()
    {
        foreach (var item in panels)
        {
            item.SetActive(false);
        }
    }

    public void ShowPanel(GameObject panel)
    {
        panel.SetActive(true);
    }

    public void HidePanel(GameObject panel)
    {
        panel.SetActive(false);
    }
}

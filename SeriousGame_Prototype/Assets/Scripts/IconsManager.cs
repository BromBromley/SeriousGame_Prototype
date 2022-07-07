using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconsManager : MonoBehaviour
{
    // attached to 01_HUD
    // this script manages the icons for the different categories of reuse and trash

    [SerializeField] private GameObject iconCan;
    [SerializeField] private GameObject icons2;
    [SerializeField] private GameObject icons3a;
    [SerializeField] private GameObject icons3b;
    [SerializeField] private GameObject infoScreen;

    public void ObjectSelected()
    {
        iconCan.SetActive(false);
        icons2.SetActive(true);
    }

    public void ReuseSelected()
    {
        icons2.SetActive(false);
        icons3a.SetActive(true);
    }

    public void TrashSelected()
    {
        icons2.SetActive(false);
        icons3b.SetActive(true);
    }

    public void ObjectCleared()
    {
        icons2.SetActive(false);
        icons3a.SetActive(false);
        icons3b.SetActive(false);
        infoScreen.SetActive(false);
        iconCan.SetActive(true);
    }

    public void ReturnToIcons2()
    {
        icons3a.SetActive(false);
        icons3b.SetActive(false);
        icons2.SetActive(true);
    }

    public void OpenInfo()
    {
        infoScreen.SetActive(true);
        iconCan.SetActive(false);
        icons2.SetActive(false);
        icons3a.SetActive(false);
        icons3b.SetActive(false);
    }
}

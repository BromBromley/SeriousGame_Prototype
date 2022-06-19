using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconsManager : MonoBehaviour
{
    [SerializeField] private GameObject iconCan;
    [SerializeField] private GameObject icons2;
    [SerializeField] private GameObject icons3a;
    [SerializeField] private GameObject icons3b;

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
        icons3a.SetActive(false);
        icons3b.SetActive(false);
        iconCan.SetActive(true);
    }

    public void ReturnToIcons2()
    {
        icons3a.SetActive(false);
        icons3b.SetActive(false);
        icons2.SetActive(true);
    }
}

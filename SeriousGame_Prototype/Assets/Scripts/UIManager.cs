using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject MainMenu;
    [SerializeField] private GameObject HUD;

    public void StartingGame()
    {
        MainMenu.SetActive(false);
        HUD.SetActive(true);
    }
}

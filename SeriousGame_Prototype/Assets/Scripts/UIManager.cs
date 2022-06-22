using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject MainMenu;
    [SerializeField] private GameObject HUD;
    [SerializeField] private GameObject PauseMenu;
    [SerializeField] private GameObject Endscreen;
    [SerializeField] private GameObject clickableObjects;

    public void StartingGame()
    {
        MainMenu.SetActive(false);
        PauseMenu.SetActive(false);
        HUD.SetActive(true);
        clickableObjects.SetActive(true);
    }

    public void PauseGame()
    {
        HUD.SetActive(false);
        PauseMenu.SetActive(true);
    }

    public void ShowEndscreen()
    {
        HUD.SetActive(false);
        PauseMenu.SetActive(false);
        Endscreen.SetActive(true);
    }
}

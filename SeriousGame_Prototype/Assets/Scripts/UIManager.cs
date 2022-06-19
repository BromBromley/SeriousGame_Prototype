using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject MainMenu;
    [SerializeField] private GameObject HUD;
    [SerializeField] private GameObject PauseMenu;

    public void StartingGame()
    {
        MainMenu.SetActive(false);
        PauseMenu.SetActive(false);
        HUD.SetActive(true);
    }

    public void PauseGame()
    {
        HUD.SetActive(false);
        PauseMenu.SetActive(true);
    }
}

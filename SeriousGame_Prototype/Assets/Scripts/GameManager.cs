using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private UIManager _uiManager;
    private IconsManager _iconsManager;
    private clickableObject _clickableObject;

    public bool reuse;
    public bool trash;

    void Start()
    {
        _uiManager = FindObjectOfType<UIManager>();
        _iconsManager = FindObjectOfType<IconsManager>();
        _clickableObject = FindObjectOfType<clickableObject>();
    }

    void Update()
    {
        if (_clickableObject.selected == false)
        {

        }

        if (_clickableObject.selected == true)
        {
            _iconsManager.ObjectSelected();
        }
    }

    public void StartGame()
    {
        _uiManager.StartingGame();
        _iconsManager.ObjectCleared();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

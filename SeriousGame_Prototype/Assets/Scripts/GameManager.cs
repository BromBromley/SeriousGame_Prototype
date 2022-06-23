using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _score;
    private UIManager _uiManager;
    private IconsManager _iconsManager;
    private clickableObjects _clickableObjects;

    public bool reuse;
    public bool trash;

    public int score = 0;
    public int counter = 10;

    void Start()
    {
        _uiManager = FindObjectOfType<UIManager>();
        _iconsManager = FindObjectOfType<IconsManager>();
        _clickableObjects = FindObjectOfType<clickableObjects>();

        counter = 10;
    }

    void Update()
    {
        //Debug.Log("counter " + counter);
        if (counter <= 0)
        {
            _uiManager.ShowEndscreen();
            _score.text = score + " Punkte erreicht";
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _uiManager.PauseGame();
        }
    }

    public void StartGame()
    {
        _uiManager.StartingGame();
        //_iconsManager.ObjectCleared();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

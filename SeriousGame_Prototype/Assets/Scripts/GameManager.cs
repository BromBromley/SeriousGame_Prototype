using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _score;
    [SerializeField] private TextMeshProUGUI _counter;

    private UIManager _uiManager;

    public bool isRunning;

    public int score = 0;
    public int counter = 10;

    void Start()
    {
        _uiManager = FindObjectOfType<UIManager>();

        counter = 10;

        isRunning = true;
    }

    void Update()
    {
        _counter.text = counter + " / 10";

        //Debug.Log("score" + score);
        //Debug.Log("counter " + counter);
        if (counter <= 0 && isRunning == true)
        {
            _uiManager.ShowEndscreen();
            _score.text = score + " Punkte erreicht";

            isRunning = false;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _uiManager.PauseGame();
        }
    }

    public void StartGame()
    {
        _uiManager.StartingGame();
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object08 : MonoBehaviour
{
    // attached to object08_frame
    // this script checks in which category the object was put and gives points accordingly

    private bool frameSelected = false;

    private GameManager _gameManager;
    private CategoryManager _categoryManager;
    private resultsCheck _resultsCheck;
    
    [SerializeField] private GameObject repairedFrame;

    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _categoryManager = FindObjectOfType<CategoryManager>();
        _resultsCheck = FindObjectOfType<resultsCheck>();
    }

    void Update()
    {
        if (frameSelected && _categoryManager.choosingCategory == false)
        {
            if (_categoryManager.choseRest == true)
            {
                frameSelected = false;

                _gameManager.score++;
                _gameManager.counter--;

                _resultsCheck.frameCorrect = true;
                this.gameObject.SetActive(false);
            }
            else if (_categoryManager.choseRepair == true)
            {
                frameSelected = false;

                _gameManager.score += 2;
                _gameManager.counter--;

                _resultsCheck.frameCorrect = true;
                this.gameObject.SetActive(false);
                repairedFrame.SetActive(true);
            }
            else 
            {
                frameSelected = false;

                _gameManager.counter--;
                this.gameObject.SetActive(false);
            }
        }
    }

    public void SelectFrame()
    {
        frameSelected = true;
        _categoryManager.choosingCategory = true;
    }
}

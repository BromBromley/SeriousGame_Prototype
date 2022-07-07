using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object07 : MonoBehaviour
{
    // attached to object07_paint
    // this script checks in which category the object was put and gives points accordingly

    private bool paintSelected = false;

    private GameManager _gameManager;
    private CategoryManager _categoryManager;
    private resultsCheck _resultsCheck;

    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _categoryManager = FindObjectOfType<CategoryManager>();
        _resultsCheck = FindObjectOfType<resultsCheck>();
    }

    void Update()
    {
        if (paintSelected && _categoryManager.choosingCategory == false)
        {
            if (_categoryManager.choseRest == true)
            {
                paintSelected = false;

                _gameManager.score++;
                _gameManager.counter--;
                
                _resultsCheck.paintCorrect = true;
                this.gameObject.SetActive(false);
            }
            else 
            {
                paintSelected = false;

                _gameManager.counter--;
                this.gameObject.SetActive(false);
            }
        }
    }

    public void SelectPaint()
    {
        paintSelected = true;
        _categoryManager.choosingCategory = true;
    }
}

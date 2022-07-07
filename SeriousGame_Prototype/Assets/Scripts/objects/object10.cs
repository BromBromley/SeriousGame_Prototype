using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object10 : MonoBehaviour
{
    // attached to object10_book
    // this script checks in which category the object was put and gives points accordingly

    private bool bookSelected = false;

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
        if (bookSelected && _categoryManager.choosingCategory == false)
        {
            if (_categoryManager.choseDonate == true)
            {
                bookSelected = true;

                _gameManager.score++;
                _gameManager.counter--;

                _resultsCheck.bookCorrect = true;
                this.gameObject.SetActive(false);
            }
            else 
            {
                bookSelected = true;

                _gameManager.counter--;
                this.gameObject.SetActive(false);
            }
        }
    }

    public void SelectBook()
    {
        bookSelected = true;
        _categoryManager.choosingCategory = true;
    }
}

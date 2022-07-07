using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object02 : MonoBehaviour
{
    // attached to object02_banana
    // this script checks in which category the object was put and gives points accordingly

    private bool bananaSelected = false;

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
        if (bananaSelected && _categoryManager.choosingCategory == false)
        {
            if (_categoryManager.choseBio == true)
            {
                bananaSelected = false;

                _gameManager.score++;
                _gameManager.counter--;
                
                _resultsCheck.bananaCorrect = true;
                this.gameObject.SetActive(false);
            }
            else
            {
                bananaSelected = false;

                _gameManager.counter--;
                this.gameObject.SetActive(false);
            }
        }
    }

    public void SelectBanana()
    {
        bananaSelected = true;
        _categoryManager.choosingCategory = true;
    }
}

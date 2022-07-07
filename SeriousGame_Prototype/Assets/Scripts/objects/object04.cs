using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object04 : MonoBehaviour
{
    // attached to object04_bag
    // this script checks in which category the object was put and gives points accordingly

    private bool bagSelected = false;

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
        if (bagSelected && _categoryManager.choosingCategory == false)
        {
            if (_categoryManager.choseWertstoff == true)
            {
                bagSelected = false;

                _gameManager.score++;
                _gameManager.counter--;

                _resultsCheck.bagCorrect = true;
                this.gameObject.SetActive(false);
            }
            else
            {
                bagSelected = false;

                _gameManager.counter--;
                this.gameObject.SetActive(false);
            }
        }
    }

    public void SelectBag()
    {
        bagSelected = true;
        _categoryManager.choosingCategory = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object05 : MonoBehaviour
{
    // attached to object05_shoes
    // this script checks in which category the object was put and gives points accordingly

    private bool shoesSelected = false;

    private GameManager _gameManager;
    private CategoryManager _categoryManager;
    private resultsCheck _resultsCheck;

    [SerializeField] private GameObject repairedShoes;

    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _categoryManager = FindObjectOfType<CategoryManager>();
        _resultsCheck = FindObjectOfType<resultsCheck>();
    }

    void Update()
    {
        if (shoesSelected && _categoryManager.choosingCategory == false)
        {
            if (_categoryManager.choseRest == true)
            {
                shoesSelected = false;

                _gameManager.score++;
                _gameManager.counter--;

                _resultsCheck.shoesCorrect = true;
                this.gameObject.SetActive(false);
            }
            else if (_categoryManager.choseRepair == true)
            {
                shoesSelected = false;

                _gameManager.score += 2;
                _gameManager.counter--;

                _resultsCheck.shoesCorrect = true;
                this.gameObject.SetActive(false);
                repairedShoes.SetActive(true);
            }
            else 
            {
                shoesSelected = false;

                _gameManager.counter--;
                this.gameObject.SetActive(false);
            }
        }
    }

    public void SelectShoes()
    {
        shoesSelected = true;
        _categoryManager.choosingCategory = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object03 : MonoBehaviour
{
    // attached to object03_paper
    // this script checks in which category the object was put and gives points accordingly

    private bool paperSelected = false;

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
        if (paperSelected && _categoryManager.choosingCategory == false)
        {
            if (_categoryManager.chosePapier == true)
            {
                paperSelected = false;

                _gameManager.score++;
                _gameManager.counter--;

                _resultsCheck.paperCorrect = true;
                this.gameObject.SetActive(false);
            }
            else
            {
                paperSelected = false;
                
                _gameManager.counter--;
                this.gameObject.SetActive(false);
            }
        }
    }

    public void SelectPaper()
    {
        paperSelected = true;
        _categoryManager.choosingCategory = true;
    }
}

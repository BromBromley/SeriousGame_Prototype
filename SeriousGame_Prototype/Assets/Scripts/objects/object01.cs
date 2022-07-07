using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object01 : MonoBehaviour
{
    // attached to object01_plant
    // this script checks in which category the object was put and gives points accordingly
    
    private bool plantSelected = false;

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
        if (plantSelected && _categoryManager.choosingCategory == false)
        {
            if (_categoryManager.choseBio == true)
            {
                plantSelected = false;

                _gameManager.score++;
                _gameManager.counter--;

                _resultsCheck.plantCorrect = true;
                this.gameObject.SetActive(false);
            }
            else
            {
                plantSelected = false;
                
                _gameManager.counter--;
                this.gameObject.SetActive(false);
            }
        }
    }

    public void SelectPlant()
    {
        plantSelected = true;
        _categoryManager.choosingCategory = true;
    }
}

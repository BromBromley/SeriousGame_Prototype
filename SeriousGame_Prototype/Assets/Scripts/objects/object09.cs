using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object09 : MonoBehaviour
{
    // attached to object09_teddy
    // this script checks in which category the object was put and gives points accordingly

    private bool teddySelected = false;

    private GameManager _gameManager;
    private CategoryManager _categoryManager;
    private resultsCheck _resultsCheck;

    [SerializeField] private GameObject repairedTeddy;

    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _categoryManager = FindObjectOfType<CategoryManager>();
        _resultsCheck = FindObjectOfType<resultsCheck>();
    }

    void Update()
    {
        if (teddySelected && _categoryManager.choosingCategory == false)
        {
            if (_categoryManager.choseRepair == true)
            {
                teddySelected = false;

                _gameManager.score++;
                _gameManager.counter--;

                _resultsCheck.teddyCorrect = true;
                this.gameObject.SetActive(false);
                repairedTeddy.SetActive(true);
            }
            else 
            {
                teddySelected = false;

                _gameManager.counter--;
                this.gameObject.SetActive(false);
            }
        }
    }

    public void SelectTeddy()
    {
        teddySelected = true;
        _categoryManager.choosingCategory = true;
    }
}

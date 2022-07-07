using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object06 : MonoBehaviour
{
    // attached to object06_socks
    // this script checks in which category the object was put and gives points accordingly

    private bool socksSelected = false;

    private GameManager _gameManager;
    private CategoryManager _categoryManager;
    private resultsCheck _resultsCheck;

    [SerializeField] private GameObject repairedSocks;

    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _categoryManager = FindObjectOfType<CategoryManager>();
        _resultsCheck = FindObjectOfType<resultsCheck>();
    }

    void Update()
    {
        if (socksSelected && _categoryManager.choosingCategory == false)
        {
            if (_categoryManager.choseRest == true)
            {
                socksSelected = false;

                _gameManager.score++;
                _gameManager.counter--;

                _resultsCheck.socksCorrect = true;
                this.gameObject.SetActive(false);
            }
            else if (_categoryManager.choseRepair == true)
            {
                socksSelected = false;

                _gameManager.score += 2;
                _gameManager.counter--;

                _resultsCheck.socksCorrect = true;
                this.gameObject.SetActive(false);
                repairedSocks.SetActive(true);
            }
            else 
            {
                socksSelected = false;

                _gameManager.counter--;
                this.gameObject.SetActive(false);
            }
        }
    }

    public void SelectSocks()
    {
        socksSelected = true;
        _categoryManager.choosingCategory = true;
    }
}

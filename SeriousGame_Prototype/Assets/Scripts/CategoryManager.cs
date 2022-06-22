using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CategoryManager : MonoBehaviour
{
    //attached to [clickableObjects]

    private clickableObjects _clickableObjects;
    private GameManager _gameManager;

    void Start()
    {
        _clickableObjects = FindObjectOfType<clickableObjects>();
        _gameManager = FindObjectOfType<GameManager>();
    }

    public void ChoseDonate()
    {
        if (_clickableObjects.bookSelected == true)
        {
            _gameManager.score++;
            _gameManager.counter--;
            _clickableObjects.selected = false;
        }

        else 
        {
            _gameManager.counter--;
            _clickableObjects.selected = false;
        }
    }

    public void ChoseRepair()
    {
        if (_clickableObjects.shoesSelected == true || _clickableObjects.socksSelected == true)
        {
            _gameManager.score += 2;
            _gameManager.counter--;
            _clickableObjects.selected = false;
        }
        else if (_clickableObjects.frameSelected == true || _clickableObjects.teddySelected == true)
        {
            _gameManager.score++;
            _gameManager.counter--;
            _clickableObjects.selected = false;
        }
        else 
        {
            _gameManager.counter--;
            _clickableObjects.selected = false;
        }
    }

    public void ChoseWertstoff()
    {
        if (_clickableObjects.bagSelected == true)
        {
            _gameManager.score++;
            _gameManager.counter--;
            _clickableObjects.selected = false;
        }

        else 
        {
            _gameManager.counter--;
            _clickableObjects.selected = false;
        }
    }

    public void ChoseBio()
    {
        if (_clickableObjects.bananaSelected == true || _clickableObjects.plantSelected == true)
        {
            _gameManager.score++;
            _gameManager.counter--;
            _clickableObjects.selected = false;
        }

        else 
        {
            _gameManager.counter--;
            _clickableObjects.selected = false;
        }
    }

    public void ChosePapier()
    {
        if (_clickableObjects.paperSelected == true)
        {
            _gameManager.score++;
            _gameManager.counter--;
            _clickableObjects.selected = false;
        }

        else 
        {
            _gameManager.counter--;
            _clickableObjects.selected = false;
        }
    }

    public void ChoseRest()
    {
        if (_clickableObjects.shoesSelected == true || _clickableObjects.socksSelected == true || _clickableObjects.paintSelected == true)
        {
            _gameManager.score++;
            _gameManager.counter--;
            _clickableObjects.selected = false;
        }

        else 
        {
            _gameManager.counter--;
            _clickableObjects.selected = false;
        }
    }
}

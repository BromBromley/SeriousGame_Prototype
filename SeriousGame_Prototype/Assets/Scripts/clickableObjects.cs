using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickableObjects : MonoBehaviour
{
    public bool plantSelected = false;
    public bool bananaSelected = false;
    public bool paperSelected = false;
    public bool bagSelected = false;
    public bool shoesSelected = false;
    public bool socksSelected = false;
    public bool paintSelected = false;
    public bool frameSelected = false;
    public bool teddySelected = false;
    public bool bookSelected = false;

    public bool selected = false;

    void Update() 
    {
        if (selected == false)
        {
            plantSelected = false;
            bananaSelected = false;
            paperSelected = false;
            bagSelected = false;
            shoesSelected = false;
            socksSelected = false;
            paintSelected = false;
            frameSelected = false;
            teddySelected = false;
            bookSelected = false;
        }
    }


    public void SelectPlant()
    {
        selected = true;
        plantSelected = true;
    }

    public void SelectBanana()
    {
        selected = true;
        bananaSelected = true;
    }

    public void SelectPaper()
    {
        selected = true;
        paperSelected = true;
    }

    public void SelectBag()
    {
        selected = true;
        bagSelected = true;
    }

    public void SelectShoes()
    {
        selected = true;
        shoesSelected = true;
    }

    public void SelectSocks()
    {
        selected = true;
        socksSelected = true;
    }

    public void SelectPaint()
    {
        selected = true;
        paintSelected = true;
    }

    public void SelectFrame()
    {
        selected = true;
        frameSelected = true;
    }

    public void SelectTeddy()
    {
        selected = true;
        teddySelected = true;
    }

    public void SelectBook()
    {
        selected = true;
        bookSelected = true;
    }
}

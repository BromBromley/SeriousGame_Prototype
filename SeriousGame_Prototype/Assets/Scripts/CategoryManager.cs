using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CategoryManager : MonoBehaviour
{
    // attached to [clickableObjects]
    // this script manages which category was chosen

    public bool choosingCategory;

    public bool choseDonate = false;
    public bool choseRepair = false;

    public bool choseWertstoff = false;
    public bool choseBio = false;
    public bool chosePapier = false;
    public bool choseRest = false;
    

    void Start()
    {
        choosingCategory = false;
    }

    void Update()
    {
        if (choosingCategory)
        {
            choseDonate = false;
            choseRepair = false;
            choseWertstoff = false;
            choseBio = false;
            chosePapier = false;
            choseRest = false;
        }
    }

    public void resetCategories()
    {
        choseDonate = false;
        choseRepair = false;
        choseWertstoff = false;
        choseBio = false;
        chosePapier = false;
        choseRest = false;
    }

    public void ChoseDonate()
    {
        choseDonate = true;
        choosingCategory = false;
    }

    public void ChoseRepair()
    {
        choseRepair = true;
        choosingCategory = false;
    }

    public void ChoseWertstoff()
    {
        choseWertstoff = true;
        choosingCategory = false;
    }

    public void ChoseBio()
    {
        choseBio = true;
        choosingCategory = false;
    }

    public void ChosePapier()
    {
        chosePapier = true;
        choosingCategory = false;
    }

    public void ChoseRest()
    {
        choseRest = true;
        choosingCategory = false;
    }
}

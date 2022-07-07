using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resultsCheck : MonoBehaviour
{
    // attached to [clickableObjects]
    // shows which objects were sorted correctly at the end of the game

    [SerializeField] private GameObject plant;
    [SerializeField] private GameObject banana;
    [SerializeField] private GameObject paper;
    [SerializeField] private GameObject bag;
    [SerializeField] private GameObject shoes;
    [SerializeField] private GameObject socks;
    [SerializeField] private GameObject paint;
    [SerializeField] private GameObject frame;
    [SerializeField] private GameObject teddy;
    [SerializeField] private GameObject book;
    [SerializeField] private GameObject repairedObjects;

    public bool plantCorrect = false;
    public bool bananaCorrect = false;
    public bool paperCorrect = false;
    public bool bagCorrect = false;
    public bool shoesCorrect = false;
    public bool socksCorrect = false;
    public bool paintCorrect = false;
    public bool frameCorrect = false;
    public bool teddyCorrect = false;
    public bool bookCorrect = false;

    public void reactivateObjects()
    {
        plant.SetActive(true);
        banana.SetActive(true);
        paper.SetActive(true);
        bag.SetActive(true);
        shoes.SetActive(true);
        socks.SetActive(true);
        paint.SetActive(true);
        frame.SetActive(true);
        teddy.SetActive(true);
        book.SetActive(true);

        repairedObjects.SetActive (false);

        showResults();
    }

    public void showResults()
    {
        if (plantCorrect)
        {
            plant.GetComponent<Image>().color = new Color(0,255, 0);
        }
        else if (plantCorrect == false)
        {
            plant.GetComponent<Image>().color = new Color(255, 0, 0);
        }

        if (bananaCorrect)
        {
            banana.GetComponent<Image>().color = new Color(0,255, 0);
        }
        else if (bananaCorrect == false)
        {
            banana.GetComponent<Image>().color = new Color(255, 0, 0);
        }

        if (paperCorrect)
        {
            paper.GetComponent<Image>().color = new Color(0,255, 0);
        }
        else if (paperCorrect == false)
        {
            paper.GetComponent<Image>().color = new Color(255, 0, 0);
        }

        if (bagCorrect)
        {
            bag.GetComponent<Image>().color = new Color(0,255, 0);   
        }
        else if (bagCorrect == false)
        {
            bag.GetComponent<Image>().color = new Color(255, 0, 0);
        }

        if (shoesCorrect)
        {
            shoes.GetComponent<Image>().color = new Color(0,255, 0);
        }
        else if (shoesCorrect == false)
        {
            shoes.GetComponent<Image>().color = new Color(255, 0, 0);
        }

        if (socksCorrect)
        {
            socks.GetComponent<Image>().color = new Color(0,255, 0);
        }
        else if (socksCorrect == false)
        {
            socks.GetComponent<Image>().color = new Color(255, 0, 0);
        }

        if (paintCorrect)
        {
            paint.GetComponent<Image>().color = new Color(0,255, 0);
        }
        else if (paintCorrect == false)
        {
            paint.GetComponent<Image>().color = new Color(255, 0, 0);
        }

        if (frameCorrect)
        {
            frame.GetComponent<Image>().color = new Color(0,255, 0);
        }
        else if (frameCorrect == false)
        {
            frame.GetComponent<Image>().color = new Color(255, 0, 0);
        }

        if (teddyCorrect)
        {
            teddy.GetComponent<Image>().color = new Color(0,255, 0);
        }
        else if (teddyCorrect == false)
        {
            teddy.GetComponent<Image>().color = new Color(255, 0, 0);
        }

        if (bookCorrect)
        {
            book.GetComponent<Image>().color = new Color(0,255, 0);
        }
        else if (bookCorrect == false)
        {
            book.GetComponent<Image>().color = new Color(255, 0, 0);
        }
    }
}

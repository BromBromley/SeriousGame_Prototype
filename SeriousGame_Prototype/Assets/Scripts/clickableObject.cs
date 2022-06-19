using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickableObject : MonoBehaviour
{
    public bool selected = false;


    public void Clicked()
    {
        transform.localScale = new Vector3(2,2,1);

        selected = true;
    }
}

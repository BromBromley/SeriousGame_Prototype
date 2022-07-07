using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectTransformation : MonoBehaviour
{
    // attached to every object
    // this script makes the objects a little bigger once they are clicked
    
    public void Clicked()
    {
        transform.localScale = new Vector3(1.3f,1.3f,1);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    GameObject gameObject;
    
    void Click()
    {
        gameObject.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject hat1;
    public GameObject ribbon1;
    public GameObject bag1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("¿Í!");

        //switch (collision.tag)
        //{
        //    case "hat1":
        //        hat1.SetActive(hat1.activeSelf ? false : true);
        //        break;
        //    case "ribbon1":
        //        ribbon1.SetActive(ribbon1.activeSelf ? false : true);
        //        break;
        //    case "bag1":
        //        bag1.SetActive(bag1.activeSelf ? false : true);
        //        break;
        //    default:
        //        break;
        //}
    }
}

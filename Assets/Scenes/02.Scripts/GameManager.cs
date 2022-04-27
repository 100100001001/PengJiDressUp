using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject hat1;
    public GameObject ribbon1;
    public GameObject bag1;

    public GameObject lens1;
    public GameObject lens2;
    public GameObject lens3;
    public GameObject lens4;
    public GameObject lens5;
    public GameObject lens6;

    public GameObject[] hairItems;
    private int hairItemsCount = 0;

    // 버튼 형식의 옷입히기
    public void Click(string type)
    {
        //switch (type)
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
        //    case "lens":
        //        lens.SetActive(lens.activeSelf ? false : true);
        //        break;
        //    default:
        //        break;
        //}
        switch (type)
        {
            case "red":
                lens1.SetActive(lens1.activeSelf ? false : true);
                break;
            case "yello":
                lens1.SetActive(lens1.activeSelf ? false : true);
                break;
            case "green":
                lens1.SetActive(lens1.activeSelf ? false : true);
                break;
            case "skyblue":
                lens1.SetActive(lens1.activeSelf ? false : true);
                break;
            case "blue":
                lens1.SetActive(lens1.activeSelf ? false : true);
                break;
            case "lilac":
                lens1.SetActive(lens1.activeSelf ? false : true);
                break;
            default:
                break;
        }
    }

    // 다시 시작
   public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // 슬롯
    public void InItemRight()
    {
        hairItems[hairItemsCount].SetActive(false);
        hairItemsCount++;

        if (hairItemsCount >= hairItems.Length)
        {
            hairItemsCount = hairItems.Length - 1;
        }
        else { hairItems[hairItemsCount].SetActive(true); }
    }

    public void InItemLeft()
    {
        hairItems[hairItemsCount].SetActive(false);
        hairItemsCount--;

        if (hairItemsCount < 0)
        {
            hairItemsCount = 0;
        }
        else { hairItems[hairItemsCount].SetActive(true); }
    }
}

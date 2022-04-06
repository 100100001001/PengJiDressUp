using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject hat1;
    public GameObject ribbon1;
    public GameObject bag1;

    // 버튼 형식의 옷입히기
    public void Click(string type)
    {
        switch (type)
        {
            case "hat1":
                hat1.SetActive(hat1.activeSelf ? false : true);
                break;
            case "ribbon1":
                ribbon1.SetActive(ribbon1.activeSelf ? false : true);
                break;
            case "bag1":
                bag1.SetActive(bag1.activeSelf ? false : true);
                break;
            default:
                break;
        }
    }

   public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

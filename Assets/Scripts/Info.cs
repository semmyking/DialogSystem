using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    public GameObject InfoText;
    public GameObject infoButton;
    public GameObject backButton;
    public void HelpButton()
    {
        InfoText.SetActive(true);
        infoButton.SetActive(false);
        backButton.SetActive(true);
        Time.timeScale = 0;

    }
    public void BackButton()
    {
        InfoText.SetActive(false);
        infoButton.SetActive(true);
        backButton.SetActive(false);
        Time.timeScale = 1; 
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_manager : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject campaignPanel;

    public void OnPlayPressed()
    {
        mainMenuPanel.SetActive(false);
        campaignPanel.SetActive(true);
    }

    public void OnBackPressed()
    {
        campaignPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

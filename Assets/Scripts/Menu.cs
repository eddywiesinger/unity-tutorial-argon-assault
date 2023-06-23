using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject menuPanel;

    void Start()
    {
        CloseMenu();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!menuPanel.activeSelf)
            {
                OpenMenu();
            }
            else
            {
                CloseMenu();
            }
        }
    }

    private void CloseMenu()
    {
        menuPanel.SetActive(false);
        Time.timeScale = 1;
    }

    private void OpenMenu()
    {
        Time.timeScale = 0;
        menuPanel.SetActive(true);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }

}

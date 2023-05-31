using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public GameObject Escape;
    // private bool escape = false;
    void Start()
    {
        Escape.SetActive(false);
    }
    private void Update()
    {


    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Escape.gameObject.SetActive(!Escape.gameObject.activeSelf);
        }
        if(Escape.gameObject.activeSelf== false)
        {
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (Escape.gameObject.activeSelf == true)
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        }


    }
    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }
    public void QuidButton()
    {
        Application.Quit();
    }
    public void ResuneButton()
    {
        Escape.gameObject.SetActive(!Escape.gameObject.activeSelf);
        Time.timeScale = 1;
    }
    public void RestartButton()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

}

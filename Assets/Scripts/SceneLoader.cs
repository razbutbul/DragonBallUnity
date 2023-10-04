using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] AboutActivation text;
    [SerializeField] PanelActivation panel;
    bool flag = false; 

    public void LoadNextScene()
    {
        int CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentSceneIndex+1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void AnAbout()
    {
        
        panel.ActivatePanel();
        text.ActivateText();
        flag = true;

     
        

    }
    private void Update()
    {
        if (flag == true)
        {
            if (Input.anyKey)
            {
                text.DeactivateText();
                panel.DeactivatePanel();
                flag = false;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{
    public void LoadScene(string scenename)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(scenename);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void Show(Animator animator)
    {
        animator.SetBool("visible", true);
    }
    public void Hide(Animator animator)
    {
        animator.SetBool("visible", false);
    }



}

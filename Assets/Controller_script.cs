using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Controller_script : MonoBehaviour
{
    public GameObject PopupBtn;

    private void Start()
    {
        PopupBtn.SetActive(false);
    }

    public void Start(Animator animator)
    {
        animator.SetBool("visible", false);

    }
    public void Show(Animator animator)
    {
        PopupBtn.SetActive(true);
        animator.SetBool("visible", true);
        Time.timeScale = 0;
    }
    public void Hide(Animator animator)
    {
        Time.timeScale = 1;
        PopupBtn.SetActive(false);

    }
}

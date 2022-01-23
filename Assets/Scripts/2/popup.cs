using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popup : MonoBehaviour
{

    bool isButton = false;
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void ClickPopUp()
    {
        if (isButton)
        {
            anim.Play("hide_popup_guid_game");
            isButton = false;
        }
        else
        {
            anim.Play("show_popup_guid_game");
            isButton = true;
        }
    }

}

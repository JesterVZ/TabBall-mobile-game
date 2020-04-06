using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogotypeLoadScreen : MonoBehaviour
{
    MenuController menuController;
    public Animator animator;
    void Start()
    {
        menuController = new MenuController();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if(animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            menuController.MainMenu();
        }
    }
}

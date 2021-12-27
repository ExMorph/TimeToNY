using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

public class KeyEvent : MonoBehaviour
{
    bool inHouse = false;
    public Animator anim;
    public UnityEvent eventActivaate;
    public bool eventWhenSceneStart = true;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Relocate();
        }
    }

    private void Start()
    {
        if (eventWhenSceneStart) eventActivaate.Invoke();
    }

    void Relocate()
    {
        anim.SetBool("In", !anim.GetBool("In"));
        eventActivaate.Invoke();
    }
}

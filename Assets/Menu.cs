using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Menu : MonoBehaviour
{
    private Animator animator;

    private static readonly int Button1 = Animator.StringToHash("Button");

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void AnimationStart()
    {
        animator.SetBool(Button1, true);
    }
    public void AnimationStop()
    {
        animator.SetBool(Button1, false);
    }
}

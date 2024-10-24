using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrapdetector : MonoBehaviour
{
    [SerializeField] Animator Animator;
    [SerializeField] bool invert, open;
    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
        Animator.SetBool("Invert", invert);
    }

    // Update is called once per frame
    public void Open()
    {
        open = true;
        Animator.SetBool("Open", open);
    }
    public void Close()
    {
        open = false;
        Animator.SetBool("Open", open);
    }
    public void Invert(bool val)
    {
        invert = val;
        Animator.SetBool("Invert", invert);
    }
}

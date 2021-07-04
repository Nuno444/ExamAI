using UnityEngine;
using System.Collections;

public class animController : MonoBehaviour
{

    public Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.Play("DoorOpened");
        }
        if (Input.GetMouseButtonDown(1))
        {
            anim.Play("DoorClosed");
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonClockwise : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject button;
    public Animator animation;

    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.Find("RotateButton");
        button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        animation.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vbh)
    {
        animation.Play("Button");
        Debug.Log("The button is pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vbh)
    {
        animation.Play("stop_animation");
        Debug.Log("The button is released");
    }

    // Update is called once per frame
    void Update()
    {

    }
}

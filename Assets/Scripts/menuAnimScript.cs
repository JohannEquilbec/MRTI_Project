using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuAnimScript : MonoBehaviour
{
    public GameObject MenuPanel;

    public void MenuAnimation()
    {
        if(MenuPanel != null)
        {
            Animator animator = MenuPanel.GetComponent<Animator>();
            if(animator != null)
            {
                bool showMenu = animator.GetBool("showMenu");
                animator.SetBool("showMenu", !showMenu);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

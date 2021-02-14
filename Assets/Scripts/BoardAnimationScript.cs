using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardAnimationScript : MonoBehaviour
{
    Transform t;


    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void rotateBoard()
    {
        Debug.Log(t.rotation);
        t.Rotate(new Vector3(0, 90, 0));
        //t.Rotate(Vector3.right*20);
    }

}

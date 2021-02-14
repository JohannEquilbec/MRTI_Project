using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARWriting : MonoBehaviour {
    public GameObject paint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) {
            //instanciate a brush
            Instantiate(paint, transform.position, transform.rotation);
        }
    }
}

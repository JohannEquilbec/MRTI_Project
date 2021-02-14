using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparencyScript : MonoBehaviour
{
    //public Slider transparencySlider;
    public GameObject brush;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void test()
    {
        Renderer renderer;
        renderer = brush.GetComponent<Renderer>();

        if (renderer != null)
        {
            //renderer.material.color.a = val;
            Color c = renderer.sharedMaterial.color;
            c.a = 0;

            renderer.sharedMaterial.SetColor("_Color", c);
        }
    }

    public void changeTransparency(float val)
    {
        Renderer renderer;
        renderer = brush.GetComponent<Renderer>();

        if (renderer != null)
        {
            //renderer.material.color.a = val;
            Color c = renderer.sharedMaterial.color;
            c.a = val;

            renderer.sharedMaterial.SetColor("_Color", c);
        }
        //float t = transparencySlider.value;
    }
}

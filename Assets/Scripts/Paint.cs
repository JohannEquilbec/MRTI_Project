using System.Collections;
using UnityEngine;

public class Paint : MonoBehaviour {
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("ARCamera");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.transform);
    }
}

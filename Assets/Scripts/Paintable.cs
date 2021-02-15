using System.Collections;
using System.IO;
using UnityEngine;

public class Paintable : MonoBehaviour
{

    public GameObject Brush;
    public float BrushSize = 0.1f;
    public RenderTexture RTexture;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0)) // Equivalent to touch the screen
        {
            // Cast a ray
            var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(Ray, out hit))
            {
                // Instanciate a brush
                var go = Instantiate(Brush, hit.point + Vector3.up * 0.05f, Quaternion.identity, transform); // Vector3.up * 0.1f
                go.transform.localScale = Vector3.one * BrushSize; 
            }

        }
    }

    public void Save()
    {
        StartCoroutine(CoSave());
    }

    private IEnumerator CoSave()
    {
        // Wait for rendering
        yield return new WaitForEndOfFrame();
        Debug.Log(Application.dataPath + "/savedImage.png");

        // Set active texture
        RenderTexture.active = RTexture;

        // Convert rendering texture to texture2D
        var texture2D = new Texture2D(RTexture.width, RTexture.height);
        texture2D.ReadPixels(new Rect(0, 0, RTexture.width, RTexture.height), 0, 0);
        texture2D.Apply();

        // Write data to file
        var data = texture2D.EncodeToPNG();
        File.WriteAllBytes(Application.dataPath + "/savedImage.png", data);


    }
}
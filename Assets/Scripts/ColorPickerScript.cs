using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

[Serializable]

public class ColorEvent : UnityEvent<Color> { }
public class ColorPickerScript : MonoBehaviour
{
    RectTransform Rec;
    Texture2D texture;
    
    public ColorEvent OnColorSelect;
    public GameObject brush;


    // Start is called before the first frame update
    void Start()
    {
        Rec = GetComponent<RectTransform>();
        texture = GetComponent<Image>().mainTexture as Texture2D;
    }

    // Update is called once per frame
    void Update()
    {
        if(RectTransformUtility.RectangleContainsScreenPoint(Rec, Input.mousePosition))
        {
            Renderer renderer;
            renderer = brush.GetComponent<Renderer>();


            Vector2 pos;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(Rec, Input.mousePosition, null, out pos);

            float width = Rec.rect.width;
            float height = Rec.rect.height;
            pos += new Vector2(width * 0.5f, height * 0.5f);

            float x = Mathf.Clamp(pos.x / width, 0f, 1f);
            float y = Mathf.Clamp(pos.y / height, 0f, 1f);

            int xTexture = Mathf.RoundToInt(x * texture.width);
            int yTexture = Mathf.RoundToInt(y * texture.height);

            Color c = texture.GetPixel(xTexture, yTexture);

            if (Input.GetMouseButton(0))
            {
                //OnColorSelect?.Invoke(c);
                if (renderer != null)
                {
                    renderer.sharedMaterial.SetColor("_Color", c);
                }
            }
        }

        
    }


}

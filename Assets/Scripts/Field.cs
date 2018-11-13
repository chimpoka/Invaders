using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    public int width = 10;
    public int height = 10;

	void Start ()
    {
        Vector3 scale = transform.localScale;
        scale.x = (float)width / 10;
        scale.z = (float)height / 10;
        transform.localScale = scale;

        Vector2 textureScale = new Vector2(width, height);
        GetComponent<Renderer>().material.mainTextureScale = textureScale;
    }
	

	void Update ()
    {
		
	}
}

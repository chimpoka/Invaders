using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{


    public static Field Create(int width, int height)
    {
        GameObject field = Instantiate(Resources.Load("Prefabs/Field") as GameObject, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        Vector3 scale = field.transform.localScale;
        scale.x = (float)width / 10;
        scale.z = (float)height / 10;
        field.transform.localScale = scale;

        Vector2 textureScale = new Vector2(width, height);
        field.GetComponent<Renderer>().material.mainTextureScale = textureScale;

        return field.gameObject.GetComponent<Field>();
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string name;
    private void OnEnable()
    {
        gameObject.name = name;
    }
    public void Draging(bool draging)
    {
        GetComponent<BoxCollider2D>().enabled = !draging;
    }
}
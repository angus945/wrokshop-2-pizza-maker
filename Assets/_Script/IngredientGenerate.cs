using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientGenerate : MonoBehaviour
{
    [SerializeField] Item generateItem;

    Item generated;

    void Start()
    {
        Generate();
    }
    void Update()
    {
        if(generated.transform.parent != transform)
        {
            Generate();
        }
    }

    void Generate()
    {
        generated = Instantiate(generateItem, transform);
        generated.transform.localPosition = Vector3.zero;
    }
}

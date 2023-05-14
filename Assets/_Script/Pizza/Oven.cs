using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oven : MonoBehaviour
{

    public Pizza pizza;

    void Update()
    {
        if(pizza != null)
        {
            pizza.bakeTime += Time.deltaTime;
            pizza.transform.position = transform.position;
        }
    }

}

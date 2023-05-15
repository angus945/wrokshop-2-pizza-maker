using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public int mvoeTimes = 3;
    public Item dropItem;

    void Start()
    {
        StartCoroutine(GetComponent<People>().RandomMove());

        GetComponent<People>().onDeathEvent += () =>
        {
            Instantiate(dropItem, transform.position, Quaternion.identity);
        };
    }



}

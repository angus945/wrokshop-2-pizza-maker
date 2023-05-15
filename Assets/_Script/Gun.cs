using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    Vector3 resetPosition;

    void Start()
    {
        resetPosition = transform.position;

        //GetComponent<Item>().onItemDrag += (bool drag) =>
        //{
        //    if (!drag) transform.position = resetPosition;
        //};
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.position = resetPosition;

        if(collision.gameObject.TryGetComponent<People>(out People people))
        {
            people.Kill();
        }
    }
}

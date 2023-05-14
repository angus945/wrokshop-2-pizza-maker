using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent<Pizza>(out Pizza pizza))
        {
            pizza.AddIngredient(this);
            this.GetComponent<BoxCollider2D>().enabled = false;
            this.GetComponent<Rigidbody2D>().simulated = false;
            transform.parent = pizza.transform;
        }
    }
}

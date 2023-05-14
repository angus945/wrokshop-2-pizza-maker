using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : MonoBehaviour
{
    public List<Ingredient> ingredients;
    public float bakeTime;

    public void AddIngredient(Ingredient ingredient)
    {
        ingredients.Add(ingredient);
        ingredient.GetComponent<SpriteRenderer>().sortingOrder = ingredients.Count + 1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent<Oven>(out Oven oven))
        {
            oven.pizza = this;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Oven>(out Oven oven))
        {
            oven.pizza = null;
        }
    }

}

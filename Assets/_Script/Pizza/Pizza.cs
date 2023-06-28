using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : MonoBehaviour
{
    public List<Ingredient> ingredients;
    float _bakeTime;
    public float bakeTime
    {
        get => _bakeTime;
        set
        {
            for (int i = 0; i < ingredients.Count; i++)
            {
                Ingredient ingredient = ingredients[i];
                ingredient.transform.Rotate(Vector3.forward * 3 * Time.deltaTime);
            }
            _bakeTime = value;
        }
    }

    public void AddIngredient(Ingredient ingredient)
    {
        ingredients.Add(ingredient);
        ingredient.GetComponentInChildren<SpriteRenderer>().sortingOrder = ingredients.Count + 1;
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

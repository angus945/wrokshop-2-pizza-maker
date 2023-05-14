using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaBar : MonoBehaviour
{
    public List<Ingredient> ingredients;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddIngredient(Ingredient ingredient)
    {
        ingredients.Add(ingredient);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coustomer : MonoBehaviour
{
    public string[] order;

    public float timer;

    void Start()
    {
        GetComponent<People>().onDeathEvent += () =>
        {
            GameManager.instance.playerHealth -= 1;
        };
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent<Pizza>(out Pizza pizza))
        {
            bool rightPizza = CheckPizzer(pizza);

            Destroy(pizza.gameObject);
        }
    }

    bool CheckPizzer(Pizza pizza)
    {
        List<string> checkOrder = new List<string>(order);

        for (int i = 0; i < pizza.ingredients.Count; i++)
        {
            string ingredient = pizza.ingredients[i].name;

            if (checkOrder.Contains(ingredient))
            {
                checkOrder.Remove(ingredient);
            }
            else return false;
        }

        return checkOrder.Count == 0;
    }
}

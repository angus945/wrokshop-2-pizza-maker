using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int playerHealth;

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleSpawn : MonoBehaviour
{
    PeopleSpawn instance;

    [SerializeField] Color spawnColor;
    [SerializeField] Color moveColor;

    [SerializeField] People[] spawnPeoples;
    [SerializeField] Vector3[] spawnPoints;
    public Vector3[] movePoint;

    [SerializeField] float spawnTime;
    float timer;

    void Awake()
    {
        instance = this;
    }

   

    void Start()
    {
        
    }
    void Update()
    {

        if(timer >= spawnTime)
        {
            SpawnPeople();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    void SpawnPeople()
    {
        Vector3 spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
        People people = spawnPeoples[Random.Range(0, spawnPeoples.Length)];

        People spawnedPeople = Instantiate(people, spawnPoint, Quaternion.identity);
        spawnedPeople.SpownBy = this;
    }

    public Vector3 GetMoveTarget()
    {
        return movePoint[Random.Range(0, instance.movePoint.Length)];
    }
    public Vector3 GetExitPoint()
    {
        return spawnPoints[Random.Range(0, instance.spawnPoints.Length)];
    }

    void OnDrawGizmos()
    {
        Gizmos.color = spawnColor;
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            Gizmos.DrawSphere(spawnPoints[i], 0.1f);
        }

        Gizmos.color = moveColor;
        for (int i = 0; i < movePoint.Length; i++)
        {
            Gizmos.DrawSphere(movePoint[i], 0.1f);
        }
    }
}

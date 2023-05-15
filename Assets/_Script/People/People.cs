using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class People : MonoBehaviour
{
    public Action onDeathEvent;
    public float moveSpeed;

    public void Kill()
    {
        onDeathEvent?.Invoke();
        Destroy(gameObject);
    }

    Vector3 target;
    public void SetTarget(bool exit)
    {
        target = exit ? PeopleSpawn.GetExitPoint() :PeopleSpawn.GetMoveTarget();
    }
    public bool MoveToTarget()
    {
        Vector3 direction = (target - transform.position).normalized;
        transform.position += direction * moveSpeed * Time.deltaTime;

        return Vector3.Distance(transform.position, target) > 1;
    }
    public IEnumerator RandomMove()
    {

        for (int i = 0; i < 3; i++)
        {
            SetTarget(false);

            while (MoveToTarget())
            {
                yield return null;
            }

            yield return new WaitForSeconds(2);

            yield return null;
        }

        SetTarget(true);

        while (MoveToTarget())
        {
            yield return null;
        }

        Destroy(gameObject);
    }
}

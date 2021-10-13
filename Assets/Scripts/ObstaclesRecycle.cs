using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesRecycle : MonoBehaviour
{
    [SerializeField]
    private Transform ball;
    private Transform obstacle;

    [SerializeField]
    private float triggerDistance;
    [SerializeField]
    private float spawnDistance;

    private Vector3 triggerHeight;

    void Start()
    {
        Debug.Log(triggerHeight);
        obstacle = GetComponent<Transform>();
        SetTrigger();
        Debug.Log(triggerHeight);
    }

    void Update()
    {
        if (ball.position.y >= triggerHeight.y && ball.position.y < (triggerHeight.y + 1))
        {
            Debug.Log("if foi feito");
            obstacle.position = triggerHeight + new Vector3(0, spawnDistance, 0);
            SetTrigger(); 
        }
    }

    private Vector3 SetTrigger()
    {
        triggerHeight = ball.position + new Vector3(0, triggerDistance, 0);
        return triggerHeight;
 
    }
}

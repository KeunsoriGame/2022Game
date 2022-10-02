using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0, -0.5f, 0);

        if(transform.position.y < -1.0f)
        {
            Destroy(gameObject);
        }
    }
}

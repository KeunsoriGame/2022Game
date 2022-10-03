using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject obstaclePrefeb;
    float span = 1.0f;
    float delta = 0;

    void Start()
    {
        Instantiate(obstaclePrefeb);
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(obstaclePrefeb) as GameObject;

            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
        
    }
}

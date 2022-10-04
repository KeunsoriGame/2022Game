using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject obstaclePrefeb;
    float span = 1.5f;
    float delta = 0;

    void Start()
    {
        GameObject newObs = Instantiate(obstaclePrefeb, transform.position, transform.rotation) as GameObject;
        newObs.transform.SetParent(GameObject.FindGameObjectWithTag("obs").transform, false);
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;

        if (this.delta > this.span)
        {
            this.delta = 0;

            int px = Random.Range(-960, 960);
            GameObject newObs = Instantiate(obstaclePrefeb, new Vector3(px, 540, 0), transform.rotation) as GameObject;
            newObs.transform.SetParent(GameObject.FindGameObjectWithTag("obs").transform, false);

            // float px = Random.Range(-6, 7);
            //newObs.transform.position= new Vector3(px, px, px);
        }

    }
}

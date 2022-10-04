using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("player");
    }

    void Update()
    {
        transform.Translate(0, -1.5f, 0);

        if (transform.position.y < -1.0f)
        {
            Destroy(gameObject);
        }


        //충돌판정
        Vector2 p1 = transform.position;  //장애물 좌표
        Vector2 p2 = this.player.transform.position;  //플레이어 좌표
        Vector2 dir = p1 - p2;

    }
}
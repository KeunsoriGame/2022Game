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


        //�浹����
        Vector2 p1 = transform.position;  //��ֹ� ��ǥ
        Vector2 p2 = this.player.transform.position;  //�÷��̾� ��ǥ
        Vector2 dir = p1 - p2;

    }
}
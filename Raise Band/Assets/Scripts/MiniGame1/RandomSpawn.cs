using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    [SerializeField] // private 함수를 inspector에서 관리 가능하게 함
    GameObject A, B, C, D, E, F;

    Vector2 creatPoint;
    int[] SpawnObj = new int[6];

    void Start()
    {
        Spawn();
    }
    void Update()
    {
        SpawnPlay();
    }

    void Spawn()
    {
        creatPoint = transform.position;
        creatPoint.x = 231f;
        creatPoint.y = 419f;
        transform.position = creatPoint;

        for (int i = 0; i < 6; i++)
        {
            SpawnObj[i] = Random.Range(1, 7);

            if (SpawnObj[i] == 1)
            {
                Instantiate(A, creatPoint, Quaternion.identity, GameObject.Find("Canvas").transform);
                creatPoint.x += 100f;
            }

            else if (SpawnObj[i] == 2)
            {
                Instantiate(B, creatPoint, Quaternion.identity, GameObject.Find("Canvas").transform);
                creatPoint.x += 100f;
            }

            else if (SpawnObj[i] == 3)
            {
                Instantiate(C, creatPoint, Quaternion.identity, GameObject.Find("Canvas").transform);
                creatPoint.x += 100f;
            }

            else if (SpawnObj[i] == 4)
            {
                Instantiate(D, creatPoint, Quaternion.identity, GameObject.Find("Canvas").transform);
                creatPoint.x += 100f;
            }

            else if (SpawnObj[i] == 5)
            {
                Instantiate(E, creatPoint, Quaternion.identity, GameObject.Find("Canvas").transform);
                creatPoint.x += 100f;
            }

            else
            {
                Instantiate(F, creatPoint, Quaternion.identity, GameObject.Find("Canvas").transform);
                creatPoint.x += 100f;
            }
        }
    }
    void SpawnPlay()
    {
        bool keydown = Input.GetKeyDown(KeyCode.Space);
        
        if (keydown)
        {
            Spawn();
        }
    }
}
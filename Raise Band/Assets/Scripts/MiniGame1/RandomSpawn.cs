using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    [SerializeField] // private 함수를 inspector에서 관리 가능하게 함
    GameObject A, B, C, D, E, F;

    int SpawnObj;

    void Update()
    {
        SpawnPlay();
    }

    void SpawnPlay()
    {
        bool keydown = Input.GetKeyDown(KeyCode.Space);

        if (keydown)
        {
            SpawnObj = Random.Range(1, 7);

            if(SpawnObj == 1)
            {
                Instantiate(A, transform.position, Quaternion.identity);
            }

            else if(SpawnObj == 2)
            {
                Instantiate(B, transform.position, Quaternion.identity);
            }

            else if(SpawnObj == 3)
            {
                Instantiate(C, transform.position, Quaternion.identity);
            }

            else if(SpawnObj == 4)
            {
                Instantiate(D, transform.position, Quaternion.identity);
            }

            else if(SpawnObj == 5)
            {
                Instantiate(E, transform.position, Quaternion.identity);
            }

            else
            {
                Instantiate(F, transform.position, Quaternion.identity);
            }

        }
    }
}
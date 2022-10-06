using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        

        // 카메라 영역 밖 제한

    }

    public void LBottonDown()
    {
        transform.Translate(-50, 0, 0);
    }

    public void RBottonDown()
    {
        transform.Translate(50, 0, 0);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            other.gameObject.SetActive(false);

            Time.timeScale = 0;
            Debug.Log("Game Over");

            //Debug.Log("충돌");
            //Destroy(other.gameObject);
        }
    }
}

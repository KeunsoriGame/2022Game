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
        

        // ī�޶� ���� �� ����

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

            //Debug.Log("�浹");
            //Destroy(other.gameObject);
        }
    }
}

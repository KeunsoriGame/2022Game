using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public float LimitTime;
    public Text txtTimer;
    public GameObject stageClear;

    void Start()
    {
 
    }

    void Update()
    {
        if (LimitTime > 0)
        {
            LimitTime -= Time.deltaTime;
            txtTimer.text = "�ð�: " + Mathf.Round(LimitTime);
        }

        else
        {
            Time.timeScale = 0;
            stageClear.gameObject.SetActive(true);
            Debug.Log("Stage Clear");

        }

    }
}

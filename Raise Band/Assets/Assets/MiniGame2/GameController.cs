using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public float LimitTime;
    public Text txtTimer;

 
    void Update()
    {
        LimitTime -= Time.deltaTime;
        txtTimer.text = "�ð�: " + Mathf.Round(LimitTime);
        
    }
}

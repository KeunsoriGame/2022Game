using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JudgeCommand : MonoBehaviour
{
    static int i = 0;

    public void ButtonA()
    {
        while(i <= 5)
        {
            if (GameObject.FindWithTag("TagA")==gameObject.transform.GetChild(1).GetChild(2).GetChild(i))
            {
                Destroy(gameObject.transform.GetChild(1).GetChild(2).GetChild(i));
                i++;
            }
        }
    }

    public void ButtonB()
    {
        while (i <= 5)
        {
            if (GameObject.FindWithTag("TagB") == gameObject.transform.GetChild(1).GetChild(2).GetChild(i))
            {
                Destroy(gameObject.transform.GetChild(1).GetChild(2).GetChild(i));
                i++;
            }
        }
    }

    public void ButtonC()
    {
        while (i <= 5)
        {
            if (GameObject.FindWithTag("TagC") == gameObject.transform.GetChild(1).GetChild(2).GetChild(i))
            {
                Destroy(gameObject.transform.GetChild(1).GetChild(2).GetChild(i));
                i++;
            }
        }
    }

    public void ButtonD()
    {
        while (i <= 5)
        {
            if (GameObject.FindWithTag("TagD") == gameObject.transform.GetChild(1).GetChild(2).GetChild(i))
            {
                Destroy(gameObject.transform.GetChild(1).GetChild(2).GetChild(i));
                i++;
            }
        }
    }

    public void ButtonE()
    {
        while (i <= 5)
        {
            if (GameObject.FindWithTag("TagE") == gameObject.transform.GetChild(1).GetChild(2).GetChild(i))
            {
                Destroy(gameObject.transform.GetChild(1).GetChild(2).GetChild(i));
                i++;
            }
        }
    }

    public void ButtonF()
    {
        while (i <= 5)
        {
            if (GameObject.FindWithTag("TagF") == gameObject.transform.GetChild(1).GetChild(2).GetChild(i))
            {
                Destroy(gameObject.transform.GetChild(1).GetChild(2).GetChild(i));
                i++;
            }
        }
    }
}

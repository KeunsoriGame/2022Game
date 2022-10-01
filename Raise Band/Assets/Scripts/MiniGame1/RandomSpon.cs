using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomSpon : MonoBehaviour
{
    public GameObject DrawWindow;
    public Image DrawImage;
    // A~F 이미지
    public Sprite A;
    public Sprite B;
    public Sprite C;
    public Sprite D;
    public Sprite E;
    public Sprite F;

    public int RandomInt; // 랜덤 변수

    void Start()
    {
        RandomInt = Random.Range(1, 7);
    }

    void Update()
    {
        
    }

    public void Draw()
    {
        if (RandomInt == 1)
        {
            DrawImage.sprite = A;
        }

        else if (RandomInt == 2)
        {
            DrawImage.sprite = B;
        }

        else if (RandomInt == 3)
        {
            DrawImage.sprite = C;
        }

        else if (RandomInt == 4)
        {
            DrawImage.sprite = D;
        }

        else if (RandomInt == 5)
        {
            DrawImage.sprite = E;
        }

        else if (RandomInt == 6)
        {
            DrawImage.sprite = F;
        }
    }
}

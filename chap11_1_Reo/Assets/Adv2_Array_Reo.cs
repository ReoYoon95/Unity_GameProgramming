using UnityEngine;

public class Adv2_Array_Reo : MonoBehaviour
{
    int[] score = { 90, 80, 100, 85, 60 };

    void Start()
    {
        int max = score[0];

        for (int i = 0; i < score.Length; i++)
        {
            if (score[i] > max)
            {
                max = score[i];
                Debug.Log($"최고점수 갱신");
            }
        }

        Debug.Log($"최고점수: {max}");
    }


    void Update()
    {

    }
}

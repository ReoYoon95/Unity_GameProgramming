using UnityEngine;

public class Adv1_Array_Reo : MonoBehaviour
{
    int[] score = { 90, 80, 100, 85, 60 };
    int sum = 0;

    void Start()
    {
        for (int i = 0; i < score.Length; i++)
        {
            sum += score[i];
        }

        Debug.Log($"합계:{sum}   평균:{sum / score.Length}");
    }


    void Update()
    {

    }
}

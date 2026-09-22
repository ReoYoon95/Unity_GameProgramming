using UnityEngine;

public class Var5_Reo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num1, num2, num3, sum;
        float average;
        num1 = 5;
        num2 = 20;
        num3 = 30;
        sum = num1 + num2 + num3;
        average = sum / 3;
        print($"종합은?{sum}");
        print($"평균은?{average}");


    }

    // Update is called once per frame
    void Update()
    {

    }
}

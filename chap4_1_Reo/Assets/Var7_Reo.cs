using UnityEngine;

public class Var7_Reo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int inc = 20;
        int inc1; //빈값 초기화
        inc1 = inc++; //inc값을 inc1에 넣고 inc값 1 증가
        print($"inc++={inc1}");
        print($"inc={inc}");
        inc1 = --inc; //inc에서 1감소시키고 나서 inc1에 넣기
        print($"--inc={inc1}");
        print($"inc={inc}");
    }

    // Update is called once per frame
    void Update()
    {

    }
}

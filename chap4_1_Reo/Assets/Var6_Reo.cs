using UnityEngine;

public class Var6_Reo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    bool trueOrFalse;

    void Start()
    {
        trueOrFalse = false;
        print($"참일까 거짓일까?{trueOrFalse}");
        print($"참일까 거짓일까?{!trueOrFalse}");
        print($"!는 반대를 나타냅니다");

    }

    // Update is called once per frame
    void Update()
    {

    }
}

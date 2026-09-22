using UnityEngine;

public class Var8_Reo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string connect1 = "연결하자";
        int inc1 = 3;
        int inc2 = 6;

        //문자열로 취급되서 연결하자 3 6 이렇게 될꺼고
        print(connect1 + inc1 + inc2);
        //뒤에 부분숫자로 9가 계산되서 연결하자 9가 될 듯.
        print(connect1 + (inc1 + inc2));

    }

    // Update is called once per frame
    void Update()
    {

    }
}

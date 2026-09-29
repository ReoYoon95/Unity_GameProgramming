using UnityEngine;

public class Var9_Reo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int myMon = 100;

    void Start()
    {
        print(myMon);
    }

    // Update is called once per frame
    void Update()
    {
        //코드1의 예시는 변수 선언없이 프린트로 호출했기에
        //오류가 발생하나, 이 코드는 함수 밖에서 변수를 선언해주었기
        //불러와도 오류가 발생하지 않음.
        print(myMon);
    }
}

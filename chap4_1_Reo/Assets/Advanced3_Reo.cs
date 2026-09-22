using UnityEngine;

public class Advanced3_Reo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public int a = 10; //퍼블릭 변수
    string b = "abc";   //프라이빗 변수

    void Update()

    {

        int c = 5;  //지역변수

        print(a + b + c);

    }
}

using UnityEngine;

public class Var10_Reo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string s1 = "하나"; //퍼블릭변수
    public int k1 = 1; //퍼블릭변수
    float f1 = 21.2f; //프라이빗변수

    void Start()
    {
        int n2 = 2; //지역변수

        print(s1 + k1 + f1);
        print(s1 + (k1 + n2 + f1));

    }

    // Update is called once per frame
    void Update()
    {

    }
}

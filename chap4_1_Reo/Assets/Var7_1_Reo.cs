using UnityEngine;

public class Var7_1_Reo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string str = "happy ";
        int num1 = 123;
        int num2 = 456;
        string message = str + num1;
        Debug.Log(message);
        //해피123456
        Debug.Log($"{message}{num2}");
        //해피123 456
        Debug.Log($"{message} {num2}");
    }

    // Update is called once per frame
    void Update()
    {

    }
}

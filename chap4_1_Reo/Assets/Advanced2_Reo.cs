using UnityEngine;

public class Advanced2_Reo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string s1 = "하나";
    public int k1 = 1;

    void Start()
    {

        int n2 = 2;
        print($"s1={s1}");   // (가)

        print($"n2={n2}");   // (나)

    }

    // Update is called once per frame
    void Update()
    {

    }
}

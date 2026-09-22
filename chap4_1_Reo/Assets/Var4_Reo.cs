using UnityEngine;

public class Var4_Reo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int myage = 10;
        int myTel = 20;
        string name = "su";
        float mySpeed;
        bool isAlive = true;
        mySpeed = myage;

        print($"나이는?{myage}");
        print($"전화번호는?{myTel}");
        print($"이름은?{name}");
        print($"속도는?{mySpeed}");
        print($"건강해?{isAlive}");

    }

    // Update is called once per frame
    void Update()
    {

    }
}

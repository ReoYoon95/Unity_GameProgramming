using UnityEngine;

public class Advanced1_Reo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()

    {

        int inc = 20;

        int inc1;

        inc1 = inc++;

        print("inc++=" + inc1);

        print("inc=" + inc);

        inc1 = --inc;

        print("--inc=" + inc1);

        print("inc=" + inc);



        int dec = 10;

        int dec1;

        dec1 = dec--;

        print("dec--=" + dec1);

        print("dec=" + dec);

        dec1 = ++dec;

        print("++dec=" + dec1);

        print("dec=" + dec);
    }

    // Update is called once per frame
    void Update()
    {

    }


}
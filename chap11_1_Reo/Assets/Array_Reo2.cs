using UnityEngine;

public class Array_Reo2 : MonoBehaviour
{
    string[] bab = { "짜장면", "학식", "감자탕" };

    void Start()
    {
        for (int i = 0; i < bab.Length; i++)
        {
            Debug.Log(bab[i]);
        }
    }


    void Update()
    {

    }
}

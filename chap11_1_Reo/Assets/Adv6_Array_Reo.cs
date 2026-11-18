using UnityEngine;

public class Adv6_Array_Reo : MonoBehaviour
{
    string[] bab = { "짜장면", "짬뽕", "김치찌개" };

    void Start()
    {
        for (int i = bab.Length - 1; i >= 0; i--)
        {
            Debug.Log($"{i} : {bab[i]}");
        }
    }

    //가 2:김치찌개
    //나 0:짜장면
    //다 2줄


}
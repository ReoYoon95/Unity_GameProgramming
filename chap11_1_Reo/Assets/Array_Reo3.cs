using UnityEngine;

public class Array_Reo3 : MonoBehaviour
{
    int[] Nov = { 1, 2, 3, 4, 5 };

    void Start()
    {
        for (int i = 0; i < Nov.Length; i++)
        {
            Debug.Log($"11월은 {Nov[i]}");
        }
    }


    void Update()
    {

    }
}

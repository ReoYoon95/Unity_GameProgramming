using UnityEngine;

public class Adv_Reo2 : MonoBehaviour
{
    int hit = 0;

    void OnCollisionEnter(Collision col)
    {
        hit++;
        Debug.Log($"충돌 횟수: {hit}");
        if (hit == 3)
        {
            Debug.Log("3번 부딛힘!");
        }

    }
}

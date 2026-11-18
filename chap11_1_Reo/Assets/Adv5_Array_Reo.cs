using UnityEngine;

public class Adv5_Array_Reo : MonoBehaviour
{
    int total, eat = 0;

    void Start()
    {
        total = GameObject.FindGameObjectsWithTag("Coin").Length;
    }

    void OnTriggerEnter(Collider col2)
    {
        if (col2.tag == "Coin")
        {
            Destroy(col2.gameObject);
            eat++;
            if (eat == total)
            {
                Debug.Log($"코인을 모두 먹었습니다.");
            }
        }

    }
}
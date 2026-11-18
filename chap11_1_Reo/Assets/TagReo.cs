using UnityEngine;

public class TagReo : MonoBehaviour
{
    int cnt = 0;

    void Start()
    {
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");

        for (int i = 0; i < coins.Length; i++)
        {
            Debug.Log(coins[i].name);
            cnt++;
        }

        Debug.Log($"총코인수는 {cnt}");

    }

    void Update()
    {

    }
}

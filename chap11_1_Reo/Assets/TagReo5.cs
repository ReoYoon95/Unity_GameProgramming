using UnityEngine;

public class TagReo5 : MonoBehaviour
{
    int cntR = 0;
    int cntY = 0;

    void Start()
    {
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");
        GameObject[] rcoins = GameObject.FindGameObjectsWithTag("RC");

        for (int i = 0; i < coins.Length; i++)
        {
            //Debug.Log(coins[i].name);
            //Debug.Log(rcoins[i].name);
            cntR++;
        }

        for (int i = 0; i < rcoins.Length; i++)
        {
            //Debug.Log(coins[i].name);
            //Debug.Log(rcoins[i].name);
            cntY++;
        }

        Debug.Log($"노란코인수는 {cntR}, 레드코인수는 {cntY}\n");

    }

    void Update()
    {

    }
}

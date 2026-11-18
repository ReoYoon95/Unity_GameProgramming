using UnityEngine;

public class Adv3_Array_Reo : MonoBehaviour
{


    void Start()
    {
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");

        for (int i = 0; i < coins.Length; i++)
        {
            coins[i].transform.Rotate(0, 0, 90);
        }
    }


    void Update()
    {

    }
}

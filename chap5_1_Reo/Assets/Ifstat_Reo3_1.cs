using UnityEngine;

public class Ifstat_Reo3_1 : MonoBehaviour
{
    int hp = 1;

    void Start()
    {

    }

    void Update()
    {
        hp += 1;
        Debug.Log($"hp : {hp}");
        if (hp <= 50) Debug.Log("도망");
        else if (hp >= 200) Debug.Log("공격!");
        else Debug.Log("방어!");

    }
}

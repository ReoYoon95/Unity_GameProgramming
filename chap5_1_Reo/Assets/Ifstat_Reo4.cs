using UnityEngine;

public class Ifstat_Reo4 : MonoBehaviour
{
    int hp = 0;

    void OnMouseDown()
    {
        hp += 1;
        if (hp % 2 == 0)
        {
            GetComponent<Renderer>().material.color = Color.yellow;
            Debug.Log("짝수번 클릭(노랑)");
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.blue;
            Debug.Log("홀수번 클릭(파랑)");
        }
    }


    void Start()
    {

    }

    void Update()
    {

    }
}

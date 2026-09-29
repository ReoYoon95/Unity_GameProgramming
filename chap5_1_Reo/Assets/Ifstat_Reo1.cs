using UnityEngine;

public class Ifstat_Reo1 : MonoBehaviour
{
    int hp = 0;
    void OnMouseDown()
    {
        hp += 10;
        if (hp >= 30)
        {
            Debug.Log("사라짐");
            Destroy(gameObject); //객체가 사라짐
        }
    }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

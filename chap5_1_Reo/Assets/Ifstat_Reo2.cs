using UnityEngine;

public class Ifstat_Reo2 : MonoBehaviour
{
    Rigidbody rd;
    int hp = 0;

    void Start()
    {
        rd = gameObject.GetComponent<Rigidbody>();
        rd.Sleep(); //큐브가 힘을 뺴고 있음

    }

    void OnMouseDown()
    {
        hp += 5;
        Debug.Log($"hp : {hp}");
        if (hp >= 15)
        {
            rd.WakeUp();
            Debug.Log("나 떨어짐");
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}

using UnityEngine;

public class Ifstat_Reo3 : MonoBehaviour
{
    int hp = 10;
    Rigidbody rd;

    void Start()
    {
        rd = gameObject.GetComponent<Rigidbody>();
        rd.Sleep();

    }

    void OnMouseDown()
    {
        hp -= 4;
        Debug.Log($"hp : {hp}");
        if (hp < 0)
        {
            rd.WakeUp();
            Debug.Log("나 떨어짐");
        }
        else Debug.Log("아직 허공에 있음");

    }

    void Update()
    {

    }
}

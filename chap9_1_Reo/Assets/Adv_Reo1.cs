using UnityEngine;

public class Adv_Reo1 : MonoBehaviour
{
    Vector3 grow = new Vector3(0.01f, 0.01f, 0.01f);
    Vector3 start = new Vector3(1, 1, 1);

    void Start()
    {

    }

    void Update()
    {
        transform.localScale += grow;
        if (transform.localScale.x > 3)
        {
            transform.localScale = start;
        }
    }
}

using UnityEngine;

public class Trap_Reo4 : MonoBehaviour
{
    float delta = 0.1f;

    void Start()
    {
    }

    void Update()
    {
        float newZPosition = transform.position.z + delta; // 앞뒤로 (z축으로) 이동
        transform.position = new Vector3(transform.position.x, transform.position.y, newZPosition);
        if (transform.position.z < -22)
        {
            delta = 0.1f;
        }

        else if (transform.position.z > 15)
        {
            delta = -0.1f;
        }
    }
}

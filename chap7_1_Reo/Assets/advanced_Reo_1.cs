using UnityEngine;

public class advanced_Reo_1 : MonoBehaviour
{
    float delta = 0.1f;

    void Start()
    {
    }

    void Update()
    {
        float newZPosition = transform.position.z + delta; // (z축으로) 이동
        float newXPosition = transform.position.x + delta; // (x축으로) 이동
        transform.position = new Vector3(newXPosition, transform.position.y, newZPosition);
        if (transform.position.z < -5 && transform.position.x < -5)
        {
            delta = 0.1f;
        }

        else if (transform.position.z > 5 && transform.position.x > 5)
        {
            delta = -0.1f;
        }
    }
}

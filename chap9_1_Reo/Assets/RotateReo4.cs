using UnityEngine;

public class RotateReo4 : MonoBehaviour
{
    public Transform k1;

    void Start()
    {
    }

    void Update()
    {
        k1.transform.Rotate(0, 0, -5);

    }
}

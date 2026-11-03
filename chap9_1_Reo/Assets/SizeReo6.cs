using UnityEngine;

public class SizeReo6 : MonoBehaviour
{
    public Transform k1;
    float s1 = 0f;

    void Start()
    {

    }

    void Update()
    {
        k1.transform.localScale = new Vector3(1 + s1, 1, 1);
        s1++;
    }
}

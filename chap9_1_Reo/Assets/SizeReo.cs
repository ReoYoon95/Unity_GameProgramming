using UnityEngine;

public class SizeReo : MonoBehaviour
{
    public Transform k1;
    void Start()
    {

    }

    void Update()
    {
        k1.transform.localScale = new Vector3(2, 1, 1);
    }
}

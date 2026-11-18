using UnityEngine;

public class CoinReo : MonoBehaviour
{
    void Start()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Sphere")
        {
            gameObject.transform.Rotate(0, 0, 90);
        }
    }
}


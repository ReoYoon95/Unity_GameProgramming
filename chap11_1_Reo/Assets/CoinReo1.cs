using UnityEngine;

public class CoinReo1 : MonoBehaviour
{
    void Start()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Sphere")
        {
            gameObject.transform.Rotate(0, 0, 90);
            gameObject.transform.position = new Vector3(transform.position.x, 10, transform.position.z);
        }
    }
}


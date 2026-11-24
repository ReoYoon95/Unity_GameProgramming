using UnityEngine;

public class ballReo2 : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "YCoin")
        {
            Destroy(col.gameObject);
        }
        if (col.tag == "GCoin")
        {
            Destroy(col.gameObject);
        }
    }

}

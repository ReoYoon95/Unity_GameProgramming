using UnityEngine;

public class ballReo1 : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "YCoin")
        {
            Destroy(col.gameObject);
        }
    }

}

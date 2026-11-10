using UnityEngine;

public class Adv_Reo1 : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Sphere")
        {
            Destroy(col.gameObject);
        }
    }

}

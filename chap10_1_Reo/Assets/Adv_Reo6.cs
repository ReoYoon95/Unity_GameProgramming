using UnityEngine;

public class Adv_Reo6 : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Debug.Log($"{gameObject.name} <- {col.gameObject.name}");
    }
}

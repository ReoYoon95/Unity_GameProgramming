using UnityEngine;

public class CollisionReo1 : MonoBehaviour
{
    void Start()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log($"나: {gameObject.name}");
        if (col.gameObject.name == "Cylinder")
        {
            Debug.Log($"나와 충돌한 객체: {col.gameObject.name}");
        }

    }

    void Update()
    {

    }
}

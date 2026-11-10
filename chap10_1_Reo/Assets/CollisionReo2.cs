using UnityEngine;

public class CollisionReo2 : MonoBehaviour
{
    void Start()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log($"나: {gameObject.name}");
        Debug.Log($"나와 충돌한 객체: {col.gameObject.name}");

    }

    void Update()
    {

    }
}

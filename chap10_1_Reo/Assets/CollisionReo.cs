using UnityEngine;

public class CollisionReo : MonoBehaviour
{
    void Start()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        //Debug.Log($"나: {gameObject.name}");
        //Debug.Log($"나와 충돌한 객체: {col.gameObject.name}");
        Vector3 direction = transform.position - col.gameObject.transform.position;
        //Debug.Log($"정규화전-> {direction}");
        direction = direction.normalized;
        //Debug.Log($"정규화후-> {direction}");
        col.gameObject.GetComponent<Rigidbody>().AddForce(-direction * 400f);
        gameObject.GetComponent<Rigidbody>().AddForce(direction * 400f);

    }

    void Update()
    {

    }
}

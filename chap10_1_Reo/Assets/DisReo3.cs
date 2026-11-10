using UnityEngine;

public class DisReo3 : MonoBehaviour
{
    public GameObject cap1; //cap1->Cylinder
    void Start()
    {
        Debug.Log($"나: {gameObject.name}");
        Vector3 direction = transform.position - cap1.gameObject.transform.position;
        Debug.Log($"정규화전-> {direction}");
        direction = direction.normalized;
        Debug.Log($"정규화후-> {direction}");

    }

    void Update()
    {

    }
}

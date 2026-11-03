using UnityEngine;

public class Adv_Reo3 : MonoBehaviour
{
    public Transform body;
    public Transform chest;
    public Transform head;

    void Start()
    {
        MakeBall(body, 3, 1.5f);
        MakeBall(chest, 2, 4.0f);
        MakeBall(head, 1, 5.5f);

    }

    void MakeBall(Transform t, float size, float y)
    {
        t.localScale = new Vector3(size, size, size);
        t.position = new Vector3(0, y, 0);

    }
}

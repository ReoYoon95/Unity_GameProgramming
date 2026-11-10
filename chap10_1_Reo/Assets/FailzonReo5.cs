using UnityEngine;

public class FailzonReo5 : MonoBehaviour
{
    int cnt = 0;

    void OnTriggerEnter(Collider col2)
    {
        cnt++;
        Debug.Log($"Fail을 통과한 객체수는? : {cnt}");
        Debug.Log(col2.gameObject.name);
    }

    void Update()
    {

    }
}

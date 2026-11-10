using UnityEngine;
using UnityEngine.SceneManagement;

public class FailzonReo6 : MonoBehaviour
{
    void Start()
    {

    }

    void OnTriggerEnter(Collider col2)
    {
        //Debug.Log("Fail을 통과한 객체는?");
        Debug.Log(col2.gameObject.name);
        if (col2.gameObject.name == "Sphere" || col2.gameObject.name == "Cylinder")
        {
            SceneManager.LoadScene("col_Reo");
        }
    }

    void Update()
    {

    }
}

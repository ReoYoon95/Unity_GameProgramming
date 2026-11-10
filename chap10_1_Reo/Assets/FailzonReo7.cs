using UnityEngine;
using UnityEngine.SceneManagement;

public class FailzonReo7 : MonoBehaviour
{

    void OnTriggerEnter(Collider col2)
    {
        Debug.Log(col2.gameObject.name);
        if (col2.gameObject.name == "Cube")
        {
            SceneManager.LoadScene("col_Reo");
        }
    }

    void Update()
    {

    }
}

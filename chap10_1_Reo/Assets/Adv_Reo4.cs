using UnityEngine;
using UnityEngine.SceneManagement;


public class Adv_Reo4 : MonoBehaviour
{
    void OnTriggerEnter(Collider col2)
    {
        if (col2.gameObject.name == " Sphere")
        {
            SceneManager.LoadScene("col_Reo");

        }
        else
        {
            Debug.Log($"{col2.gameObject.name} 통과");
        }
    }
}

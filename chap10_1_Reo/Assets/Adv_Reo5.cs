using UnityEngine;
using UnityEngine.SceneManagement;

public class Adv_Reo5 : MonoBehaviour
{
    void OnTriggerEnter(Collider col2)
    {
        if (col2.gameObject.name == "Cube")
            SceneManager.LoadScene(1);
    }

}

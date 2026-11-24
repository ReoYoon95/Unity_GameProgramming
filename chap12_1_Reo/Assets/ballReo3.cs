using UnityEngine;

public class ballReo3 : MonoBehaviour
{
    GameObject GM;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "YCoin")
        {
            Destroy(col.gameObject);
            GM = GameObject.Find("GameManager");
            GM.GetComponent<gameManagerS>().CountMethod();
            GM.GetComponent<gameManagerS>().ToCount();
        }

    }

}

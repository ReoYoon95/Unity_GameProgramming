using UnityEngine;

public class ballReo4 : MonoBehaviour
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

        if (col.tag == "GCoin")
        {
            Destroy(col.gameObject);
            GM = GameObject.Find("GameManager");
            GM.GetComponent<gameManagerS>().GetGreen();
        }
    }

}

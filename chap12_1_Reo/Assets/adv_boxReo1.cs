using UnityEngine;

public class adv_boxReo1 : MonoBehaviour
{

    GameObject GM;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Ball")
        {
            Destroy(col.gameObject);
            GM = GameObject.Find("GameManager");
            GM.GetComponent<gameManagerS1_adv>().CountMethod();
        }
    }

}

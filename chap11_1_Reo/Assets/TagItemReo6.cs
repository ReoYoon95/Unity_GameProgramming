using UnityEngine;

public class TagItemReo6 : MonoBehaviour
{
    void Start()
    {

    }

    void OnTriggerEnter(Collider col2)
    {
        if (col2.tag == "Coin")
        {
            col2.gameObject.transform.position = new Vector3(-2, col2.transform.position.y, col2.transform.position.z);

        }

        if (col2.tag == "RC")
        {
            //Destroy(col2.gameObject);
            col2.gameObject.transform.position = new Vector3(2, col2.transform.position.y, col2.transform.position.z);

        }
    }

}

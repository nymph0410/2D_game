using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject final;

    public Text textCount;

    public int count;


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.name =="����")
        {
            final.SetActive(true);
        }

        if (collision.tag == "��l")
        {
            Destroy(collision.gameObject);
        }

        count++;

        textCount.text = "��l�ƶq�G" + count;
    }
}

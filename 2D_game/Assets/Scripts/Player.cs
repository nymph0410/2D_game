using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject final;

    public Text textCount;

    public int count;


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.name =="獎盃")
        {
            final.SetActive(true);
        }

        if (collision.tag == "橘子")
        {
            Destroy(collision.gameObject);
        }

        count++;

        textCount.text = "橘子數量：" + count;
    }
}

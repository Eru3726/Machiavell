using UnityEngine;
using System.Collections;

public class healPortion : MonoBehaviour
{
    private Vector2 force;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        force = new Vector2(Time.deltaTime, 5.0f);
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(force,ForceMode2D.Impulse);
        GetComponent<BoxCollider2D>().enabled = false;
        StartCoroutine(boxOn());
    }
    //private void OnClolisionEnter2D(Collider2D other)
    //{
    //    if (other.CompareTag("grand"))
    //    {
    //        rb.bodyType = RigidbodyType2D.Kinematic;
    //    }
    //}
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "grand")
        {
            //rb.bodyType = RigidbodyType2D.Kinematic;
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        if (other.gameObject.name == "player" && GameData.healpotion < 2)
        {
            Destroy(gameObject);
            GameData.healpotion += 1;
        }
    }
    IEnumerator boxOn()
    {
        yield return new WaitForSeconds(0.4f);
        GetComponent<BoxCollider2D>().enabled = true;
    }
}

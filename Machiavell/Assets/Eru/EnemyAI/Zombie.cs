using UnityEngine;

public class Zombie : MonoBehaviour
{
    private MoveLeftRight moveLR;

    private Rigidbody2D rb2d;

    [SerializeField]
    private float speed;
    private float moveSpeed;

    void Start()
    {
        moveLR = new MoveLeftRight();
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        speed = moveLR.MoveChk(transform, speed);

        rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
    }
}

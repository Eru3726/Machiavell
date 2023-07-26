using UnityEngine;

public class TalisShot : MonoBehaviour
{
    private Vector2 dir;

    private Transform myTransform;

    [SerializeField]
    private Transform coreTransform;

    [SerializeField]
    private GameObject blast;

    [SerializeField, Tooltip("DataBase")]
    private Enemy talis;

    private void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    public void Shot()
    {
        Vector3 v3 = new Vector3(myTransform.transform.position.x, myTransform.transform.position.y, myTransform.transform.position.z);
        dir = v3 - coreTransform.transform.position;
        dir.Normalize();
        GameObject bls = (GameObject)Instantiate(blast, v3, Quaternion.FromToRotation(Vector2.up, dir));
        Rigidbody2D brb = bls.GetComponent<Rigidbody2D>();
        brb.velocity = dir * talis.enemyChaseSpeed;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lod : MonoBehaviour
{
    [SerializeField, Header("DataBase")]
    private Enemy Archange;
    public float godLodDamage;

    private float timer = 3;
    private Vector3 lod;
    void Start()
    {
        godLodDamage = Archange.enemyGodLodAtk;
        Debug.Log(godLodDamage);
    }
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer<0)
        {
            lod = this.gameObject.transform.localScale;
            lod.x -= 0.01f;
            this.gameObject.transform.localScale = lod;
            if (lod.x<0)
            {
                Destroy(gameObject);
            }
        }
    }
}

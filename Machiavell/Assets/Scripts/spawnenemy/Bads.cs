using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bads : MonoBehaviour
{
    private string type;
    private int maxHp, offens, defnse, resilience;
    private float speed;
    public Enemy bad;
    // Start is called before the first frame update
    void Start()
    {
        this.type = bad.enemyName;
        this.maxHp = bad.enemyMaxHp;
        this.offens = bad.enemyOffensivePower;
        this.defnse = bad.enemyDefensePower;
        this.speed = bad.enemyMoveSpeed;
        this.resilience = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void baddebug()
    {
        Debug.Log(type);
        Debug.Log(maxHp);
        Debug.Log(offens);
        Debug.Log(defnse);
        Debug.Log(speed);
    }
}

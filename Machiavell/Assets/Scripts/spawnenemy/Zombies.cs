using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombies : MonoBehaviour
{
    private string type;
    private int maxHp, offens, defnse, resilience;
    private float speed;
    public Enemy zombie;
    // Start is called before the first frame update
    void Start()
    {
        this.type = zombie.enemyName;
        this.maxHp = zombie.enemyMaxHp;
        this.offens = zombie.enemyOffensivePower;
        this.defnse = zombie.enemyDefensePower;
        this.speed = zombie.enemyMoveSpeed;
        this.resilience = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void zombiedebug()
    {
        Debug.Log(type);
        Debug.Log(maxHp);
        Debug.Log(offens);
        Debug.Log(defnse);
        Debug.Log(speed);
    }
}

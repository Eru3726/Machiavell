using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slimes : MonoBehaviour
{
    private string type;
    private int maxHp, offens, defnse, resilience;
    private float speed;
    public Enemy slime;
    // Start is called before the first frame update
    void Start()
    {
        this.type = slime.enemyName;
        this.maxHp = slime.enemyMaxHp;
        this.offens = slime.enemyOffensivePower;
        this.defnse = slime.enemyDefensePower;
        this.speed = slime.enemyMoveSpeed;
        this.resilience = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void slimedebug()
    {
        Debug.Log(type);
        Debug.Log(maxHp);
        Debug.Log(offens);
        Debug.Log(defnse);
        Debug.Log(speed);
    }
}

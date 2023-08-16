using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    //float Dameg = Script1.ATK;
    //public GameObject wepon;
    public int A;
    public Script1 B;
    public int C;
    //public SaveData C;
    //public SaveData D;

    float Dameg1;

    public float ATK;
    public float DEF = 2;
    public float HP = 30;

    public static float enemyATK = 3;

    private Rigidbody2D rb2d;
    BoxCollider2D bc2d;

    // Start is called before the first frame update
    void Start()
    {
        float WeponAtk;
        float buki;
        buki = GameData.soubi;

        rb2d = GetComponent<Rigidbody2D>();
        bc2d = GetComponent<BoxCollider2D>();

        Debug.Log(buki);
        if (buki == 1)
        {
            WeponAtk = GameData.weaponAttack[0];
            ATK = WeponAtk;
            Debug.Log("buki1");
        }
        else if (buki == 2)
        {
            WeponAtk = GameData.weaponAttack[1];
            ATK = WeponAtk;
            Debug.Log("buki2");
        }
        else if (buki == 3)
        {
            WeponAtk = GameData.weaponAttack[2];
            ATK = WeponAtk;
            Debug.Log("buki3");
        }
        else if (buki == 4)
        {
            WeponAtk = GameData.weaponAttack[3];
            ATK = WeponAtk;
            Debug.Log("buki4");
        }
        else if (buki == 5)
        {
            WeponAtk = GameData.weaponAttack[4];
            ATK = WeponAtk;
            Debug.Log("buki5");
        }
        else if (buki == 6)
        {
            WeponAtk = GameData.weaponAttack[5];
            ATK = WeponAtk;
            Debug.Log("buki6");
        }
        else if (buki == 7)
        {
            WeponAtk = GameData.weaponAttack[6];
            ATK = WeponAtk;
            Debug.Log("buki7");
        }
        else if (buki == 8)
        {
            WeponAtk = GameData.weaponAttack[7];
            ATK = WeponAtk;
            Debug.Log("buki8");
        }
        else if (buki == 9)
        {
            WeponAtk = GameData.weaponAttack[8];
            ATK = WeponAtk;
            Debug.Log("buki9");
        }
        else if (buki == 10)
        {
            WeponAtk = GameData.weaponAttack[9];
            ATK = WeponAtk;
            Debug.Log("buki10");
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D wepon)
    {
        float Dameg2;
        float Dameg;
        Dameg2 = GameData.playeroffence;
        Dameg1 = ATK;

        if (wepon.gameObject.CompareTag("Attack"))
        {
            C = 0;

            Dameg = Dameg1 + Dameg2;
            if(Dameg <= DEF) { HP -= 1;}
            else { HP -= (Dameg - DEF); }

            if(HP <= 0) { Destroy(gameObject); }

            A = 1;
            Debug.Log(Dameg + "‚ð—^‚¦‚½I");
            Debug.Log(Dameg1 + "‚ð—^‚¦‚½II");
            Debug.Log(Dameg2 + "‚ð—^‚¦‚½II");
            StartCoroutine(hantei());
        }
    }

    IEnumerator hantei()
    {
        C = 1;
        yield return new WaitForSeconds(3.0f); //3•bŒã‚Éˆ—‚ð‚·‚é
        A = 0;
    }

}

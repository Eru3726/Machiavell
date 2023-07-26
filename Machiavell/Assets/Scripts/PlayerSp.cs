using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSp : MonoBehaviour
{
    //ステータスポイント
    public static int sp = 0;

    //スキルポイント追加
    public void AddSp(int add)
    {
        sp += add;
        Debug.Log("Spを：" + add + "入手しました");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (sp > 0)
            {
                sp -= 1;
                PlayerS.maxhp += 10;
                Debug.Log("hp上昇" + PlayerS.maxhp);
                Debug.Log("残りSP" + sp);
            }
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (sp > 0)
            {
                sp -= 1;
                PlayerS.maxstamina += 10;
                Debug.Log("スタミナ上昇" + PlayerS.maxstamina);
                Debug.Log("残りSP" + sp);
            }
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (sp > 0)
            {
                sp -= 1;
                PlayerS.offensePower += 1;
                Debug.Log("攻撃力上昇" + PlayerS.offensePower);
                Debug.Log("残りSP" + sp);
            }
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (sp > 0)
            {
                sp -= 1;
                PlayerS.defensePower += 1;
                Debug.Log("防御力上昇" + PlayerS.defensePower);
                Debug.Log("残りSP" + sp);
            }
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (sp > 0)
            {
                sp -= 1;
                PlayerS.lucky += 1;
                Debug.Log("幸運上昇" + PlayerS.lucky);
                Debug.Log("残りSP" + sp);
            }
        }

    }

    public void debug()
    {
        Debug.Log("残りsp" + sp);
    }
}

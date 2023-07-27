using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStatus : MonoBehaviour
{
    public  GameObject weapon;
    public  GameObject sannsyou;　　　　　//オブジェクトを一時保存してステータスをふるための変数
    bool fusionsannsyou;
    private float whp = 100;
    private float wstamina = 100;
    private float wattack = 1;
    private float wguard = 1;
    private float wluck = 1;
    private float rnd;
    private float wlevel = 1;
    private int needsp = 1;
    private int needspup = 4;    //必要なステータスを増やすやつ
    private float count = 1;     //レベルアップまでのカウント
    private float upcount = 1;   //必要なステータスが増えるまでのカウント
    void Start()
    {
        weapon = gameObject;
        if (gameObject.tag == "weapon2")
        {
            whp += 900;
            wstamina += 900;
            wattack += 99;
            wguard += 99;
            wluck += 99;
        }
        if (gameObject.tag == "weapon3")
        {
            whp += 1900;
            wstamina += 1900;
            wattack += 199;
            wguard += 199;
            wluck += 199;
        }
        if (gameObject.tag == "weapon4")
        {
            whp += 2900;
            wstamina += 2900;
            wattack += 299;
            wguard += 299;
            wluck += 299;
        }
        if (gameObject.tag == "weapon5")
        {
            whp += 3900;
            wstamina += 3900;
            wattack += 399;
            wguard += 399;
            wluck += 399;
        }

        //ドロップした時ランダムにステータスを変える
        if (weapon.tag != "weapon1")
        {
            rnd = Random.Range(-5, 6);
            whp += rnd;
            rnd = Random.Range(-5, 6);
            wstamina += rnd;
            rnd = Random.Range(-5, 6);
            wattack += rnd;
            rnd = Random.Range(-5, 6);
            wguard += rnd;
            rnd = Random.Range(-5, 6);
            wluck += rnd;
        }
    }

    void Update()
    {

        if (count >= 5)
        {
            wlevel += 1;
            upcount += 1;
            if (upcount >= 5)
            {
                needsp += needspup;
                upcount = 0;
                needspup++;
            }
            count = 0;
            Debug.Log("武器のレベルが" + wlevel + "になりました");
        }
    }

    public void whpup()
    {
        //必要なステータスの値分減らす
        PlayerS.maxhp -= needsp * 10;
        whp += 10;
        Debug.Log("武器体力上昇" + whp);
        count += 1;
    }
    public void wstaminaup()
    {
        PlayerS.maxstamina -= needsp * 10;
        wstamina += 10;
        Debug.Log("武器スタミナ上昇" + wstamina);
        count += 1;
    }
    public void wattackup()
    {
        PlayerS.offensePower -= needsp;
        wattack += 1;
        Debug.Log("武器攻撃力上昇" + wattack);
        count += 1;
    }
    public void wguardup()
    {
        PlayerS.defensePower -= needsp;
        wguard += 1;
        Debug.Log("武器防御力上昇" + wguard);
        count += 1;
    }
    public void wluckup()
    {
        PlayerS.lucky -= needsp;
        wluck += 1;
        Debug.Log("武器幸運上昇" + wluck);
        count += 1;
    }
    //レベルアップと共に必要なステータスの値を増やす
   
    public void wstatusreset()
    {
        //武器のレベル、強化に必要なステータスなどのリセット
        wlevel = 1;
        needsp = 1;
        count = 1;
        upcount = 1;
        Debug.Log("合成されステータスがリセットされました");
    }
    public float dwhp()
    {
        return whp;
    }

    public float dwstamina()
    {
        return wstamina;
    }

    public float dwattack()
    {
        return wattack;
    }
    public float dwguard()
    {
        return wguard;
    }
    public float dwluck()
    {
        return wluck;
    }
    public float dwlevel()
    {
        return wlevel;
    }
    
    public float need()
    {
        return needsp;
    }
    

    //クリックしたオブジェクトを参照する
    public void Click()
    {
        //合成用の参照プログラムが機能してないとき
        if (fusionsannsyou == false)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (hit2d)
            {
                sannsyou = hit2d.transform.gameObject;
            }
        }
    }
}

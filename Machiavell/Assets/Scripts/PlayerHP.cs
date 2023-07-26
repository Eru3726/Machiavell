using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{

    //プレイヤーダメージ
    public void PlayerDamage(int damage)
    {
        Debug.Log("プレイヤーが" + damage + "ダメージを受けました");
        PlayerS.hp -= damage;
    }

    //プレイヤーヒール
    public void PlayerHeal(int heal)
    {
        if (PlayerS.maxhp - PlayerS.hp >= heal)
        Debug.Log("プレイヤーが" + heal + "回復しました");
        PlayerS.hp += heal;
    }
}

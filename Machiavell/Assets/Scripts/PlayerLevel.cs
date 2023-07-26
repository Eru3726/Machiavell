using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevel : MonoBehaviour
{
    public static int playerLevel = 1;     //プレイヤーレベル
    public static int nextLevel = 3;       //次のレベルに上がるために必要な経験値
    public static int getXp = 0;           //入手している経験値

    public PlayerSp pp;

    private void Update()
    {
        //レベルアップ
        if (getXp >= nextLevel)
        {
            playerLevel++;
            Debug.Log("プレイヤーのレベルが" + playerLevel + "になりました");
            getXp -= nextLevel;
            nextLevel = playerLevel * playerLevel + playerLevel;                        // Y = X^2 + X
            Debug.Log("次のレベルアップまであと" + (nextLevel - getXp) + "Xpです");
            GetSp();
        }
    }

    //Xpの追加
    public void Xp(int xp)
    {
        getXp += xp;
        Debug.Log(xp + "Xp入手しました");
    }

    //Sp入手判定
    public void GetSp()
    {
        if(playerLevel % 5 == 0)
        {
            pp.AddSp(5 * (playerLevel / 5));
        }
    }
}

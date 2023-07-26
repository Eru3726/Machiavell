//データをファイルに保存します

using System.IO;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Save : MonoBehaviour
{
    public bool config = false;
    void OnEnable()
    {
        DoSave();
    }

    private void DoSave()
    {
#if UNITY_EDITOR
        //UnityEditor上なら
        //Assetファイルの中のSaveファイルのパスを入れる
        string path = Application.dataPath + "/Save";

#else
        //そうでなければ
        //.exeがあるところにSaveファイルを作成しそこのパスを入れる
        Directory.CreateDirectory("Save");
        string path = Directory.GetCurrentDirectory() + "/Save";
        
#endif

        //セーブファイルのパスを設定
        string SaveFilePath = path + "/save" + DataManager.saveFile + ".bytes";

        // セーブデータの作成
        SaveData saveData = CreateSaveData();

        // セーブデータをJSON形式の文字列に変換
        string jsonString = JsonUtility.ToJson(saveData);

        // 文字列をbyte配列に変換
        byte[] bytes = Encoding.UTF8.GetBytes(jsonString);

        // AES暗号化
        byte[] arrEncrypted = AesEncrypt(bytes);

        // 指定したパスにファイルを作成
        FileStream file = new FileStream(SaveFilePath, FileMode.Create, FileAccess.Write);

        //ファイルに保存する
        try
        {
            // ファイルに保存
            file.Write(arrEncrypted, 0, arrEncrypted.Length);

        }
        finally
        {
            // ファイルを閉じる
            if (file != null)
            {
                file.Close();
            }
        }
        this.enabled = false;//このスクリプトをオフにする
    }

    // セーブデータの作成
    private SaveData CreateSaveData()
    {
        //セーブデータのインスタンス化
        SaveData saveData = new SaveData();

        //ゲームデータの値をセーブデータに代入
        saveData.rightkey = GameData.rightkey;
        saveData.righttx = GameData.righttx;
        saveData.leftkey = GameData.leftkey;
        saveData.lefttx = GameData.lefttx;
        saveData.jumpkey = GameData.jumpkey;
        saveData.jumptx = GameData.jumptx;
        saveData.attackkey = GameData.attackkey;
        saveData.attacktx = GameData.attacktx;
        saveData.dashkey = GameData.dashkey;
        saveData.dashtx = GameData.dashtx;
        saveData.healkey = GameData.healkey;
        saveData.healtx = GameData.healtx;
        saveData.menukey = GameData.menukey;
        saveData.menutx = GameData.menutx;
        saveData.downkey = GameData.downkey;
        saveData.downtx = GameData.downtx;
        saveData.interactkey = GameData.interactkey;
        saveData.interacttx = GameData.interacttx;
        //if (config == false)
        //{
        saveData.inventoryWeapon1 = GameData.inventoryWeapon1;
        saveData.inventoryWeapon2 = GameData.inventoryWeapon2;
        saveData.inventoryWeapon3 = GameData.inventoryWeapon3;
        saveData.inventoryWeapon4 = GameData.inventoryWeapon4;
        saveData.inventoryWeapon5 = GameData.inventoryWeapon5;
        saveData.inventoryWeapon6 = GameData.inventoryWeapon6;
        saveData.inventoryWeapon7 = GameData.inventoryWeapon7;
        saveData.inventoryWeapon8 = GameData.inventoryWeapon8;
        saveData.inventoryWeapon9 = GameData.inventoryWeapon9;
        saveData.inventoryWeapon10 = GameData.inventoryWeapon10;
        saveData.weaponRarity1 = GameData.weaponRarity1;
        saveData.weaponRarity2 = GameData.weaponRarity2;
        saveData.weaponRarity3 = GameData.weaponRarity3;
        saveData.weaponRarity4 = GameData.weaponRarity4;
        saveData.weaponRarity5 = GameData.weaponRarity5;
        saveData.weaponRarity6 = GameData.weaponRarity6;
        saveData.weaponRarity7 = GameData.weaponRarity7;
        saveData.weaponRarity8 = GameData.weaponRarity8;
        saveData.weaponRarity9 = GameData.weaponRarity9;
        saveData.weaponRarity10 = GameData.weaponRarity10;
        saveData.weaponHp1 = GameData.weaponHp1;
        saveData.weaponneedHp1 = GameData.weaponneedHp1;
        saveData.weaponhpcount1 = GameData.weaponhpcount1;
        saveData.weaponHp2 = GameData.weaponHp2;
        saveData.weaponneedHp2 = GameData.weaponneedHp2;
        saveData.weaponhpcount2 = GameData.weaponhpcount2;
        saveData.weaponHp3 = GameData.weaponHp3;
        saveData.weaponneedHp3 = GameData.weaponneedHp3;
        saveData.weaponhpcount3 = GameData.weaponhpcount3;
        saveData.weaponHp4 = GameData.weaponHp4;
        saveData.weaponneedHp4 = GameData.weaponneedHp4;
        saveData.weaponhpcount4 = GameData.weaponhpcount4;
        saveData.weaponHp5 = GameData.weaponHp5;
        saveData.weaponneedHp5 = GameData.weaponneedHp5;
        saveData.weaponhpcount5 = GameData.weaponhpcount5;
        saveData.weaponHp6 = GameData.weaponHp6;
        saveData.weaponneedHp6 = GameData.weaponneedHp6;
        saveData.weaponhpcount6 = GameData.weaponhpcount6;
        saveData.weaponHp7 = GameData.weaponHp7;
        saveData.weaponneedHp7 = GameData.weaponneedHp7;
        saveData.weaponhpcount7 = GameData.weaponhpcount7;
        saveData.weaponHp8 = GameData.weaponHp8;
        saveData.weaponneedHp8 = GameData.weaponneedHp8;
        saveData.weaponhpcount8 = GameData.weaponhpcount8;
        saveData.weaponHp9 = GameData.weaponHp9;
        saveData.weaponneedHp9 = GameData.weaponneedHp9;
        saveData.weaponhpcount9 = GameData.weaponhpcount9;
        saveData.weaponHp10 = GameData.weaponHp10;
        saveData.weaponneedHp10 = GameData.weaponneedHp10;
        saveData.weaponhpcount10 = GameData.weaponhpcount10;
        saveData.weaponStamina1 = GameData.weaponStamina1;
        saveData.weaponneedStamina1 = GameData.weaponneedStamina1;
        saveData.weaponStaminacount1 = GameData.weaponStaminacount1;
        saveData.weaponStamina2 = GameData.weaponStamina2;
        saveData.weaponneedStamina2 = GameData.weaponneedStamina2;
        saveData.weaponStaminacount2 = GameData.weaponStaminacount2;
        saveData.weaponStamina3 = GameData.weaponStamina3;
        saveData.weaponneedStamina3 = GameData.weaponneedStamina3;
        saveData.weaponStaminacount3 = GameData.weaponStaminacount3;
        saveData.weaponStamina4 = GameData.weaponStamina4;
        saveData.weaponneedStamina4 = GameData.weaponneedStamina4;
        saveData.weaponStaminacount4 = GameData.weaponStaminacount4;
        saveData.weaponStamina5 = GameData.weaponStamina5;
        saveData.weaponneedStamina5 = GameData.weaponneedStamina5;
        saveData.weaponStaminacount5 = GameData.weaponStaminacount5;
        saveData.weaponStamina6 = GameData.weaponStamina6;
        saveData.weaponneedStamina6 = GameData.weaponneedStamina6;
        saveData.weaponStaminacount6 = GameData.weaponStaminacount6;
        saveData.weaponStamina7 = GameData.weaponStamina7;
        saveData.weaponneedStamina7 = GameData.weaponneedStamina7;
        saveData.weaponStaminacount7 = GameData.weaponStaminacount7;
        saveData.weaponStamina8 = GameData.weaponStamina8;
        saveData.weaponneedStamina8 = GameData.weaponneedStamina8;
        saveData.weaponStaminacount8 = GameData.weaponStaminacount8;
        saveData.weaponStamina9 = GameData.weaponStamina9;
        saveData.weaponneedStamina9 = GameData.weaponneedStamina9;
        saveData.weaponStaminacount9 = GameData.weaponStaminacount9;
        saveData.weaponStamina10 = GameData.weaponStamina10;
        saveData.weaponneedStamina10 = GameData.weaponneedStamina10;
        saveData.weaponStaminacount10 = GameData.weaponStaminacount10;
        saveData.weaponAttack1 = GameData.weaponAttack1;
        saveData.weaponneedAttack1 = GameData.weaponneedAttack1;
        saveData.weaponAttackcount1 = GameData.weaponAttackcount1;
        saveData.weaponAttack2 = GameData.weaponAttack2;
        saveData.weaponneedAttack2 = GameData.weaponneedAttack2;
        saveData.weaponAttackcount2 = GameData.weaponAttackcount2;
        saveData.weaponAttack3 = GameData.weaponAttack3;
        saveData.weaponneedAttack3 = GameData.weaponneedAttack3;
        saveData.weaponAttackcount3 = GameData.weaponAttackcount3;
        saveData.weaponAttack4 = GameData.weaponAttack4;
        saveData.weaponneedAttack4 = GameData.weaponneedAttack4;
        saveData.weaponAttackcount4 = GameData.weaponAttackcount4;
        saveData.weaponAttack5 = GameData.weaponAttack5;
        saveData.weaponneedAttack5 = GameData.weaponneedAttack5;
        saveData.weaponAttackcount5 = GameData.weaponAttackcount5;
        saveData.weaponAttack6 = GameData.weaponAttack6;
        saveData.weaponneedAttack6 = GameData.weaponneedAttack6;
        saveData.weaponAttackcount6 = GameData.weaponAttackcount6;
        saveData.weaponAttack7 = GameData.weaponAttack7;
        saveData.weaponneedAttack7 = GameData.weaponneedAttack7;
        saveData.weaponAttackcount7 = GameData.weaponAttackcount7;
        saveData.weaponAttack8 = GameData.weaponAttack8;
        saveData.weaponneedAttack8 = GameData.weaponneedAttack8;
        saveData.weaponAttackcount8 = GameData.weaponAttackcount8;
        saveData.weaponAttack9 = GameData.weaponAttack9;
        saveData.weaponneedAttack9 = GameData.weaponneedAttack9;
        saveData.weaponAttackcount9 = GameData.weaponAttackcount9;
        saveData.weaponAttack10 = GameData.weaponAttack10;
        saveData.weaponneedAttack10 = GameData.weaponneedAttack10;
        saveData.weaponAttackcount10 = GameData.weaponAttackcount10;
        saveData.weaponGuard1 = GameData.weaponGuard1;
        saveData.weaponneedGuard1 = GameData.weaponneedGuard1;
        saveData.weaponGuardcount1 = GameData.weaponGuardcount1;
        saveData.weaponGuard2 = GameData.weaponGuard2;
        saveData.weaponneedGuard2 = GameData.weaponneedGuard2;
        saveData.weaponGuardcount2 = GameData.weaponGuardcount2;
        saveData.weaponGuard3 = GameData.weaponGuard3;
        saveData.weaponneedGuard3 = GameData.weaponneedGuard3;
        saveData.weaponGuardcount3 = GameData.weaponGuardcount3;
        saveData.weaponGuard4 = GameData.weaponGuard4;
        saveData.weaponneedGuard4 = GameData.weaponneedGuard4;
        saveData.weaponGuardcount4 = GameData.weaponGuardcount4;
        saveData.weaponGuard5 = GameData.weaponGuard5;
        saveData.weaponneedGuard5 = GameData.weaponneedGuard5;
        saveData.weaponGuardcount5 = GameData.weaponGuardcount5;
        saveData.weaponGuard6 = GameData.weaponGuard6;
        saveData.weaponneedGuard6 = GameData.weaponneedGuard6;
        saveData.weaponGuardcount6 = GameData.weaponGuardcount6;
        saveData.weaponGuard7 = GameData.weaponGuard7;
        saveData.weaponneedGuard7 = GameData.weaponneedGuard7;
        saveData.weaponGuardcount7 = GameData.weaponGuardcount7;
        saveData.weaponGuard8 = GameData.weaponGuard8;
        saveData.weaponneedGuard8 = GameData.weaponneedGuard8;
        saveData.weaponGuardcount8 = GameData.weaponGuardcount8;
        saveData.weaponGuard9 = GameData.weaponGuard9;
        saveData.weaponneedGuard9 = GameData.weaponneedGuard9;
        saveData.weaponGuardcount9 = GameData.weaponGuardcount9;
        saveData.weaponGuard10 = GameData.weaponGuard10;
        saveData.weaponneedGuard10 = GameData.weaponneedGuard10;
        saveData.weaponGuardcount10 = GameData.weaponGuardcount10;
        saveData.weaponLuck1 = GameData.weaponLuck1;
        saveData.weaponneedLuck1 = GameData.weaponneedLuck1;
        saveData.weaponLuckcount1 = GameData.weaponLuckcount1;
        saveData.weaponLuck2 = GameData.weaponLuck2;
        saveData.weaponneedLuck2 = GameData.weaponneedLuck2;
        saveData.weaponLuckcount2 = GameData.weaponLuckcount2;
        saveData.weaponLuck3 = GameData.weaponLuck3;
        saveData.weaponneedLuck3 = GameData.weaponneedLuck3;
        saveData.weaponLuckcount3 = GameData.weaponLuckcount3;
        saveData.weaponLuck4 = GameData.weaponLuck4;
        saveData.weaponneedLuck4 = GameData.weaponneedLuck4;
        saveData.weaponLuckcount4 = GameData.weaponLuckcount4;
        saveData.weaponLuck5 = GameData.weaponLuck5;
        saveData.weaponneedLuck5 = GameData.weaponneedLuck5;
        saveData.weaponLuckcount5 = GameData.weaponLuckcount5;
        saveData.weaponLuck6 = GameData.weaponLuck6;
        saveData.weaponneedLuck6 = GameData.weaponneedLuck6;
        saveData.weaponLuckcount6 = GameData.weaponLuckcount6;
        saveData.weaponLuck7 = GameData.weaponLuck7;
        saveData.weaponneedLuck7 = GameData.weaponneedLuck7;
        saveData.weaponLuckcount7 = GameData.weaponLuckcount7;
        saveData.weaponLuck8 = GameData.weaponLuck8;
        saveData.weaponneedLuck8 = GameData.weaponneedLuck8;
        saveData.weaponLuckcount8 = GameData.weaponLuckcount8;
        saveData.weaponLuck9 = GameData.weaponLuck9;
        saveData.weaponneedLuck9 = GameData.weaponneedLuck9;
        saveData.weaponLuckcount9 = GameData.weaponLuckcount9;
        saveData.weaponLuck10 = GameData.weaponLuck10;
        saveData.weaponneedLuck10 = GameData.weaponneedLuck10;
        saveData.weaponLuckcount10 = GameData.weaponLuckcount10;
        saveData.weaponLevel1 = GameData.weaponLevel1;
        saveData.weaponLevel2 = GameData.weaponLevel2;
        saveData.weaponLevel3 = GameData.weaponLevel3;
        saveData.weaponLevel4 = GameData.weaponLevel4;
        saveData.weaponLevel5 = GameData.weaponLevel5;
        saveData.weaponLevel6 = GameData.weaponLevel6;
        saveData.weaponLevel7 = GameData.weaponLevel7;
        saveData.weaponLevel8 = GameData.weaponLevel8;
        saveData.weaponLevel9 = GameData.weaponLevel9;
        saveData.weaponLevel10 = GameData.weaponLevel10;
        saveData.playerlevel = GameData.playerlevel;
        saveData.playerexp = GameData.playerexp;
        saveData.needEXP = GameData.needEXP;
        saveData.needEXPcount = GameData.needEXPcount;
        saveData.playerhp = GameData.playerhp;
        saveData.playerhpnow = GameData.playerhpnow;
        saveData.playerstamina = GameData.playerstamina;
        saveData.playeroffence = GameData.playeroffence;
        saveData.playerdeffence = GameData.playerdeffence;
        saveData.playerluck = GameData.playerluck;
        saveData.playerneedsp = GameData.playerneedsp;
        saveData.playerstatuspoint = GameData.playerstatuspoint;
        saveData.needspcount = GameData.needspcount;
        saveData.soubi = GameData.soubi;
        saveData.first = GameData.first;
        saveData.sky = GameData.sky;
        saveData.save = GameData.save;
        saveData.healpotion = GameData.healpotion;
        Debug.Log("全部セーブー");
        //}
        //else
        //{
        //    config = false;
        //    Debug.Log("コンフィグだけya");
        //    return saveData;
        //}
        return saveData;
    }


    /// AesManagedマネージャーを取得

    private AesManaged GetAesManager()
    {
        //任意の半角英数16文字(Read.csと同じやつに)
        string aesIv = "2675282924673034";
        string aesKey = "3278967013810443";

        AesManaged aes = new AesManaged();
        aes.KeySize = 128;
        aes.BlockSize = 128;
        aes.Mode = CipherMode.CBC;
        aes.IV = Encoding.UTF8.GetBytes(aesIv);
        aes.Key = Encoding.UTF8.GetBytes(aesKey);
        aes.Padding = PaddingMode.PKCS7;
        return aes;
    }

    /// AES暗号化
    public byte[] AesEncrypt(byte[] byteText)
    {
        // AESマネージャーの取得
        AesManaged aes = GetAesManager();
        // 暗号化
        byte[] encryptText = aes.CreateEncryptor().TransformFinalBlock(byteText, 0, byteText.Length);

        return encryptText;
    }

}
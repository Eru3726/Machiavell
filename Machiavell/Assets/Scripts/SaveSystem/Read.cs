//ファイルのデータを読み込みます

using System.IO;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;

public class Read : MonoBehaviour
{
    void OnEnable()
    {
        DoRead();
    }

    private void DoRead()
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

        //セーブファイルがあるか
        if (File.Exists(SaveFilePath))
        {
            DataManager.saveData = true;

            //ファイルモードをオープンにする
            FileStream file = new FileStream(SaveFilePath, FileMode.Open, FileAccess.Read);
            try
            {
                // ファイル読み込み
                byte[] arrRead = File.ReadAllBytes(SaveFilePath);

                // 復号化
                byte[] arrDecrypt = AesDecrypt(arrRead);

                // byte配列を文字列に変換
                string decryptStr = Encoding.UTF8.GetString(arrDecrypt);

                // JSON形式の文字列をセーブデータのクラスに変換
                SaveData saveData = JsonUtility.FromJson<SaveData>(decryptStr);

                //データの反映
                ReadData(saveData);

            }
            finally
            {
                // ファイルを閉じる
                if (file != null)
                {
                    file.Close();
                }
            }
        }
        else
        {
            Debug.Log("セーブファイルがありません");
            DataManager.saveData = false;
        }

        this.enabled = false;

    }

    //データの読み込み（反映）
    private void ReadData(SaveData saveData)
    {
        GameData.rightkey = saveData.rightkey;
        GameData.righttx = saveData.righttx;
        GameData.leftkey = saveData.leftkey;
        GameData.lefttx = saveData.lefttx;
        GameData.jumpkey = saveData.jumpkey;
        GameData.jumptx = saveData.jumptx;
        GameData.attackkey = saveData.attackkey;
        GameData.attacktx = saveData.attacktx;
        GameData.dashkey = saveData.dashkey;
        GameData.dashtx = saveData.dashtx;
        GameData.healkey = saveData.healkey;
        GameData.healtx = saveData.healtx;
        GameData.menukey = saveData.menukey;
        GameData.menutx = saveData.menutx;
        GameData.downkey = saveData.downkey;
        GameData.downtx = saveData.downtx;
        GameData.interactkey = saveData.interactkey;
        GameData.interacttx = saveData.interacttx;
        GameData.inventoryWeapon1 = saveData.inventoryWeapon1;
        GameData.inventoryWeapon2 = saveData.inventoryWeapon2;
        GameData.inventoryWeapon3 = saveData.inventoryWeapon3;
        GameData.inventoryWeapon4 = saveData.inventoryWeapon4;
        GameData.inventoryWeapon5 = saveData.inventoryWeapon5;
        GameData.inventoryWeapon6 = saveData.inventoryWeapon6;
        GameData.inventoryWeapon7 = saveData.inventoryWeapon7;
        GameData.inventoryWeapon8 = saveData.inventoryWeapon8;
        GameData.inventoryWeapon9 = saveData.inventoryWeapon9;
        GameData.inventoryWeapon10 = saveData.inventoryWeapon10;
        GameData.weaponRarity1 = saveData.weaponRarity1;
        GameData.weaponRarity2 = saveData.weaponRarity2;
        GameData.weaponRarity3 = saveData.weaponRarity3;
        GameData.weaponRarity4 = saveData.weaponRarity4;
        GameData.weaponRarity5 = saveData.weaponRarity5;
        GameData.weaponRarity6 = saveData.weaponRarity6;
        GameData.weaponRarity7 = saveData.weaponRarity7;
        GameData.weaponRarity8 = saveData.weaponRarity8;
        GameData.weaponRarity9 = saveData.weaponRarity9;
        GameData.weaponRarity10 = saveData.weaponRarity10;
        GameData.weaponHp1 = saveData.weaponHp1;
        GameData.weaponneedHp1 = saveData.weaponneedHp1;
        GameData.weaponhpcount1 = saveData.weaponhpcount1;
        GameData.weaponHp2 = saveData.weaponHp2;
        GameData.weaponneedHp2 = saveData.weaponneedHp2;
        GameData.weaponhpcount2 = saveData.weaponhpcount2;
        GameData.weaponHp3 = saveData.weaponHp3;
        GameData.weaponneedHp3 = saveData.weaponneedHp3;
        GameData.weaponhpcount3 = saveData.weaponhpcount3;
        GameData.weaponHp4 = saveData.weaponHp4;
        GameData.weaponneedHp4 = saveData.weaponneedHp4;
        GameData.weaponhpcount4 = saveData.weaponhpcount4;
        GameData.weaponHp5 = saveData.weaponHp5;
        GameData.weaponneedHp5 = saveData.weaponneedHp5;
        GameData.weaponhpcount5 = saveData.weaponhpcount5;
        GameData.weaponHp6 = saveData.weaponHp6;
        GameData.weaponneedHp6 = saveData.weaponneedHp6;
        GameData.weaponhpcount6 = saveData.weaponhpcount6;
        GameData.weaponHp7 = saveData.weaponHp7;
        GameData.weaponneedHp7 = saveData.weaponneedHp7;
        GameData.weaponhpcount7 = saveData.weaponhpcount7;
        GameData.weaponHp8 = saveData.weaponHp8;
        GameData.weaponneedHp8 = saveData.weaponneedHp8;
        GameData.weaponhpcount8 = saveData.weaponhpcount8;
        GameData.weaponHp9 = saveData.weaponHp9;
        GameData.weaponneedHp9 = saveData.weaponneedHp9;
        GameData.weaponhpcount9 = saveData.weaponhpcount9;
        GameData.weaponHp10 = saveData.weaponHp10;
        GameData.weaponneedHp10 = saveData.weaponneedHp10;
        GameData.weaponhpcount10 = saveData.weaponhpcount10;
        GameData.weaponStamina1 = saveData.weaponStamina1;
        GameData.weaponneedStamina1 = saveData.weaponneedStamina1;
        GameData.weaponStaminacount1 = saveData.weaponStaminacount1;
        GameData.weaponStamina2 = saveData.weaponStamina2;
        GameData.weaponneedStamina2 = saveData.weaponneedStamina2;
        GameData.weaponStaminacount2 = saveData.weaponStaminacount2;
        GameData.weaponStamina3 = saveData.weaponStamina3;
        GameData.weaponneedStamina3 = saveData.weaponneedStamina3;
        GameData.weaponStaminacount3 = saveData.weaponStaminacount3;
        GameData.weaponStamina4 = saveData.weaponStamina4;
        GameData.weaponneedStamina4 = saveData.weaponneedStamina4;
        GameData.weaponStaminacount4 = saveData.weaponStaminacount4;
        GameData.weaponStamina5 = saveData.weaponStamina5;
        GameData.weaponneedStamina5 = saveData.weaponneedStamina5;
        GameData.weaponStaminacount5 = saveData.weaponStaminacount5;
        GameData.weaponStamina6 = saveData.weaponStamina6;
        GameData.weaponneedStamina6 = saveData.weaponneedStamina6;
        GameData.weaponStaminacount6 = saveData.weaponStaminacount6;
        GameData.weaponStamina7 = saveData.weaponStamina7;
        GameData.weaponneedStamina7 = saveData.weaponneedStamina7;
        GameData.weaponStaminacount7 = saveData.weaponStaminacount7;
        GameData.weaponStamina8 = saveData.weaponStamina8;
        GameData.weaponneedStamina8 = saveData.weaponneedStamina8;
        GameData.weaponStaminacount8 = saveData.weaponStaminacount8;
        GameData.weaponStamina9 = saveData.weaponStamina9;
        GameData.weaponneedStamina9 = saveData.weaponneedStamina9;
        GameData.weaponStaminacount9 = saveData.weaponStaminacount9;
        GameData.weaponStamina10 = saveData.weaponStamina10;
        GameData.weaponneedStamina10 = saveData.weaponneedStamina10;
        GameData.weaponStaminacount10 = saveData.weaponStaminacount10;
        GameData.weaponAttack1 = saveData.weaponAttack1;
        GameData.weaponneedAttack1 = saveData.weaponneedAttack1;
        GameData.weaponAttackcount1 = saveData.weaponAttackcount1;
        GameData.weaponAttack2 = saveData.weaponAttack2;
        GameData.weaponneedAttack2 = saveData.weaponneedAttack2;
        GameData.weaponAttackcount2 = saveData.weaponAttackcount2;
        GameData.weaponAttack3 = saveData.weaponAttack3;
        GameData.weaponneedAttack3 = saveData.weaponneedAttack3;
        GameData.weaponAttackcount3 = saveData.weaponAttackcount3;
        GameData.weaponAttack4 = saveData.weaponAttack4;
        GameData.weaponneedAttack4 = saveData.weaponneedAttack4;
        GameData.weaponAttackcount4 = saveData.weaponAttackcount4;
        GameData.weaponAttack5 = saveData.weaponAttack5;
        GameData.weaponneedAttack5 = saveData.weaponneedAttack5;
        GameData.weaponAttackcount5 = saveData.weaponAttackcount5;
        GameData.weaponAttack6 = saveData.weaponAttack6;
        GameData.weaponneedAttack6 = saveData.weaponneedAttack6;
        GameData.weaponAttackcount6 = saveData.weaponAttackcount6;
        GameData.weaponAttack7 = saveData.weaponAttack7;
        GameData.weaponneedAttack7 = saveData.weaponneedAttack7;
        GameData.weaponAttackcount7 = saveData.weaponAttackcount7;
        GameData.weaponAttack8 = saveData.weaponAttack8;
        GameData.weaponneedAttack8 = saveData.weaponneedAttack8;
        GameData.weaponAttackcount8 = saveData.weaponAttackcount8;
        GameData.weaponAttack9 = saveData.weaponAttack9;
        GameData.weaponneedAttack9 = saveData.weaponneedAttack9;
        GameData.weaponAttackcount9 = saveData.weaponAttackcount9;
        GameData.weaponAttack10 = saveData.weaponAttack10;
        GameData.weaponneedAttack10 = saveData.weaponneedAttack10;
        GameData.weaponAttackcount10 = saveData.weaponAttackcount10;
        GameData.weaponGuard1 = saveData.weaponGuard1;
        GameData.weaponneedGuard1 = saveData.weaponneedGuard1;
        GameData.weaponGuardcount1 = saveData.weaponGuardcount1;
        GameData.weaponGuard2 = saveData.weaponGuard2;
        GameData.weaponneedGuard2 = saveData.weaponneedGuard2;
        GameData.weaponGuardcount2 = saveData.weaponGuardcount2;
        GameData.weaponGuard3 = saveData.weaponGuard3;
        GameData.weaponneedGuard3 = saveData.weaponneedGuard3;
        GameData.weaponGuardcount3 = saveData.weaponGuardcount3;
        GameData.weaponGuard4 = saveData.weaponGuard4;
        GameData.weaponneedGuard4 = saveData.weaponneedGuard4;
        GameData.weaponGuardcount4 = saveData.weaponGuardcount4;
        GameData.weaponGuard5 = saveData.weaponGuard5;
        GameData.weaponneedGuard5 = saveData.weaponneedGuard5;
        GameData.weaponGuardcount5 = saveData.weaponGuardcount5;
        GameData.weaponGuard6 = saveData.weaponGuard6;
        GameData.weaponneedGuard6 = saveData.weaponneedGuard6;
        GameData.weaponGuardcount6 = saveData.weaponGuardcount6;
        GameData.weaponGuard7 = saveData.weaponGuard7;
        GameData.weaponneedGuard7 = saveData.weaponneedGuard7;
        GameData.weaponGuardcount7 = saveData.weaponGuardcount7;
        GameData.weaponGuard8 = saveData.weaponGuard8;
        GameData.weaponneedGuard8 = saveData.weaponneedGuard8;
        GameData.weaponGuardcount8 = saveData.weaponGuardcount8;
        GameData.weaponGuard9 = saveData.weaponGuard9;
        GameData.weaponneedGuard9 = saveData.weaponneedGuard9;
        GameData.weaponGuardcount9 = saveData.weaponGuardcount9;
        GameData.weaponGuard10 = saveData.weaponGuard10;
        GameData.weaponneedGuard10 = saveData.weaponneedGuard10;
        GameData.weaponGuardcount10 = saveData.weaponGuardcount10;
        GameData.weaponLuck1 = saveData.weaponLuck1;
        GameData.weaponneedLuck1 = saveData.weaponneedLuck1;
        GameData.weaponLuckcount1 = saveData.weaponLuckcount1;
        GameData.weaponLuck2 = saveData.weaponLuck2;
        GameData.weaponneedLuck2 = saveData.weaponneedLuck2;
        GameData.weaponLuckcount2 = saveData.weaponLuckcount2;
        GameData.weaponLuck3 = saveData.weaponLuck3;
        GameData.weaponneedLuck3 = saveData.weaponneedLuck3;
        GameData.weaponLuckcount3 = saveData.weaponLuckcount3;
        GameData.weaponLuck4 = saveData.weaponLuck4;
        GameData.weaponneedLuck4 = saveData.weaponneedLuck4;
        GameData.weaponLuckcount4 = saveData.weaponLuckcount4;
        GameData.weaponLuck5 = saveData.weaponLuck5;
        GameData.weaponneedLuck5 = saveData.weaponneedLuck5;
        GameData.weaponLuckcount5 = saveData.weaponLuckcount5;
        GameData.weaponLuck6 = saveData.weaponLuck6;
        GameData.weaponneedLuck6 = saveData.weaponneedLuck6;
        GameData.weaponLuckcount6 = saveData.weaponLuckcount6;
        GameData.weaponLuck7 = saveData.weaponLuck7;
        GameData.weaponneedLuck7 = saveData.weaponneedLuck7;
        GameData.weaponLuckcount7 = saveData.weaponLuckcount7;
        GameData.weaponLuck8 = saveData.weaponLuck8;
        GameData.weaponneedLuck8 = saveData.weaponneedLuck8;
        GameData.weaponLuckcount8 = saveData.weaponLuckcount8;
        GameData.weaponLuck9 = saveData.weaponLuck9;
        GameData.weaponneedLuck9 = saveData.weaponneedLuck9;
        GameData.weaponLuckcount9 = saveData.weaponLuckcount9;
        GameData.weaponLuck10 = saveData.weaponLuck10;
        GameData.weaponneedLuck10 = saveData.weaponneedLuck10;
        GameData.weaponLuckcount10 = saveData.weaponLuckcount10;
        GameData.weaponLevel1 = saveData.weaponLevel1;
        GameData.weaponLevel2 = saveData.weaponLevel2;
        GameData.weaponLevel3 = saveData.weaponLevel3;
        GameData.weaponLevel4 = saveData.weaponLevel4;
        GameData.weaponLevel5 = saveData.weaponLevel5;
        GameData.weaponLevel6 = saveData.weaponLevel6;
        GameData.weaponLevel7 = saveData.weaponLevel7;
        GameData.weaponLevel8 = saveData.weaponLevel8;
        GameData.weaponLevel9 = saveData.weaponLevel9;
        GameData.weaponLevel10 = saveData.weaponLevel10;
        GameData.playerlevel = saveData.playerlevel;
        GameData.playerexp = saveData.playerexp;
        GameData.needEXP = saveData.needEXP;
        GameData.needEXPcount = saveData.needEXPcount;
        GameData.playerhp = saveData.playerhp;
        GameData.playerhpnow = saveData.playerhpnow;
        GameData.playerstamina = saveData.playerstamina;
        GameData.playeroffence = saveData.playeroffence;
        GameData.playerdeffence = saveData.playerdeffence;
        GameData.playerluck = saveData.playerluck;
        GameData.playerneedsp = saveData.playerneedsp;
        GameData.playerstatuspoint = saveData.playerstatuspoint;
        GameData.needspcount = saveData.needspcount;
        GameData.soubi = saveData.soubi;
        GameData.first = saveData.first;
        GameData.sky = saveData.sky;
        GameData.save = saveData.save;
        GameData.healpotion = saveData.healpotion;
    }


    /// AesManagedマネージャーを取得
    private AesManaged GetAesManager()
    {
        //任意の半角英数16文字(Save.csと同じやつに)
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

    /// AES復号化
    public byte[] AesDecrypt(byte[] byteText)
    {
        // AESマネージャー取得
        var aes = GetAesManager();
        // 復号化
        byte[] decryptText = aes.CreateDecryptor().TransformFinalBlock(byteText, 0, byteText.Length);

        return decryptText;
    }

}
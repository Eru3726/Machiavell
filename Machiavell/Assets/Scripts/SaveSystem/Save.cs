//データをファイルに保存します

using System.IO;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;

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

        for (int i = 0; i < 10; i++)
        {
            saveData.inventoryWeapon[i] = GameData.inventoryWeapon[i];
            saveData.weaponRarity[i] = GameData.weaponRarity[i];

            saveData.weaponHp[i] = GameData.weaponHp[i];
            saveData.weaponneedHp[i] = GameData.weaponneedHp[i];
            saveData.weaponhpcount[i] = GameData.weaponhpcount[i];
            saveData.weaponStamina[i] = GameData.weaponStamina[i];
            saveData.weaponneedStamina[i] = GameData.weaponneedStamina[i];
            saveData.weaponStaminacount[i] = GameData.weaponStaminacount[i];

            saveData.weaponAttack[i] = GameData.weaponAttack[i];
            saveData.weaponneedAttack[i] = GameData.weaponneedAttack[i];
            saveData.weaponAttackcount[i] = GameData.weaponAttackcount[i];

            saveData.weaponGuard[i] = GameData.weaponGuard[i];
            saveData.weaponneedGuard[i] = GameData.weaponneedGuard[i];
            saveData.weaponGuardcount[i] = GameData.weaponGuardcount[i];

            saveData.weaponLuck[i] = GameData.weaponLuck[i];
            saveData.weaponneedLuck[i] = GameData.weaponneedLuck[i];
            saveData.weaponLuckcount[i] = GameData.weaponLuckcount[i];

            saveData.weaponLevel[i] = GameData.weaponLevel[i];
        }

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
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

        for(int i = 0; i < 10; i++)
        {
            GameData.inventoryWeapon[i] = saveData.inventoryWeapon[i];
            GameData.weaponRarity[i] = saveData.weaponRarity[i];

            GameData.weaponHp[i] = saveData.weaponHp[i];
            GameData.weaponneedHp[i] = saveData.weaponneedHp[i];
            GameData.weaponhpcount[i] = saveData.weaponhpcount[i];
            GameData.weaponStamina[i] = saveData.weaponStamina[i];
            GameData.weaponneedStamina[i] = saveData.weaponneedStamina[i];
            GameData.weaponStaminacount[i] = saveData.weaponStaminacount[i];

            GameData.weaponAttack[i] = saveData.weaponAttack[i];
            GameData.weaponneedAttack[i] = saveData.weaponneedAttack[i];
            GameData.weaponAttackcount[i] = saveData.weaponAttackcount[i];

            GameData.weaponGuard[i] = saveData.weaponGuard[i];
            GameData.weaponneedGuard[i] = saveData.weaponneedGuard[i];
            GameData.weaponGuardcount[i] = saveData.weaponGuardcount[i];

            GameData.weaponLuck[i] = saveData.weaponLuck[i];
            GameData.weaponneedLuck[i] = saveData.weaponneedLuck[i];
            GameData.weaponLuckcount[i] = saveData.weaponLuckcount[i];

            GameData.weaponLevel[i] = saveData.weaponLevel[i];
        }

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
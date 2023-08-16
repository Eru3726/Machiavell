//�t�@�C���̃f�[�^��ǂݍ��݂܂�

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
        //UnityEditor��Ȃ�
        //Asset�t�@�C���̒���Save�t�@�C���̃p�X������
        string path = Application.dataPath + "/Save";

#else
        //�����łȂ����
        //.exe������Ƃ����Save�t�@�C�����쐬�������̃p�X������
        Directory.CreateDirectory("Save");
        string path = Directory.GetCurrentDirectory() + "/Save";

#endif

        //�Z�[�u�t�@�C���̃p�X��ݒ�
        string SaveFilePath = path + "/save" + DataManager.saveFile + ".bytes";

        //�Z�[�u�t�@�C�������邩
        if (File.Exists(SaveFilePath))
        {
            DataManager.saveData = true;

            //�t�@�C�����[�h���I�[�v���ɂ���
            FileStream file = new FileStream(SaveFilePath, FileMode.Open, FileAccess.Read);
            try
            {
                // �t�@�C���ǂݍ���
                byte[] arrRead = File.ReadAllBytes(SaveFilePath);

                // ������
                byte[] arrDecrypt = AesDecrypt(arrRead);

                // byte�z��𕶎���ɕϊ�
                string decryptStr = Encoding.UTF8.GetString(arrDecrypt);

                // JSON�`���̕�������Z�[�u�f�[�^�̃N���X�ɕϊ�
                SaveData saveData = JsonUtility.FromJson<SaveData>(decryptStr);

                //�f�[�^�̔��f
                ReadData(saveData);

            }
            finally
            {
                // �t�@�C�������
                if (file != null)
                {
                    file.Close();
                }
            }
        }
        else
        {
            Debug.Log("�Z�[�u�t�@�C��������܂���");
            DataManager.saveData = false;
        }

        this.enabled = false;

    }

    //�f�[�^�̓ǂݍ��݁i���f�j
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


    /// AesManaged�}�l�[�W���[���擾
    private AesManaged GetAesManager()
    {
        //�C�ӂ̔��p�p��16����(Save.cs�Ɠ������)
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

    /// AES������
    public byte[] AesDecrypt(byte[] byteText)
    {
        // AES�}�l�[�W���[�擾
        var aes = GetAesManager();
        // ������
        byte[] decryptText = aes.CreateDecryptor().TransformFinalBlock(byteText, 0, byteText.Length);

        return decryptText;
    }

}
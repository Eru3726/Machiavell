using UnityEngine;
//�Z�[�u���邽�߂̍���

[System.Serializable]
public class SaveData
{
    public KeyCode rightkey;
    public string righttx;
    public KeyCode leftkey;
    public string lefttx;
    public KeyCode jumpkey;
    public string jumptx;
    public KeyCode attackkey;
    public string attacktx;
    public KeyCode dashkey;
    public string dashtx;
    public KeyCode healkey;
    public string healtx;
    public KeyCode menukey;
    public string menutx;
    public KeyCode downkey;
    public string downtx;
    public KeyCode interactkey;
    public string interacttx;

    public int[] inventoryWeapon = new int[10];

    public int[] weaponRarity = new int[10];

    public int[] weaponHp = new int[10];
    public int[] weaponneedHp = new int[10];
    public int[] weaponhpcount = new int[10];

    public int[] weaponStamina = new int[10];
    public int[] weaponneedStamina = new int[10];
    public int[] weaponStaminacount = new int[10];

    public int[] weaponAttack = new int[10];
    public int[] weaponneedAttack = new int[10];
    public int[] weaponAttackcount = new int[10];

    public int[] weaponGuard = new int[10];
    public int[] weaponneedGuard = new int[10];
    public int[] weaponGuardcount = new int[10];

    public int[] weaponLuck = new int[10];
    public int[] weaponneedLuck = new int[10];
    public int[] weaponLuckcount = new int[10];

    public int[] weaponLevel = new int[10];

    public int playerexp = 0;       //�o���l
    public int playerlevel = 1;            //�v���C���[�̃��x��
    public int needEXP = 1;�@�@�@�@�@�@�@//���x���������邽�߂ɕK�v�Ȍo���l
    public int needEXPcount = 0;�@�@�@�@�@�@�@//���񂩂Ɉ�񃌃x���������邽�߂ɕK�v�Ȍo���l�𑝂₷
    public int playerhp = 100;�@�@�@�@�@�@�@�@�@�@//�v���C���[�̗̑�
    public int playerhpnow = 100;                //�v���C���[�̌��݂̗̑�
    public int playerstamina = 100;�@�@�@�@�@�@�@�@�@ //�v���C���[�̃X�^�~�i
    public int playeroffence = 1;                   //�v���C���[�̍U��
    public int playerdeffence = 1;                   //�v���C���[�̖h��
    public int playerluck = 1;                   //�v���C���[�̉^
    public int playerstatuspoint = 0;                   //�v���C���[�̃X�e�[�^�X�|�C���g
    public int playerneedsp = 1;               //�X�e�[�^�X�����ɕK�v�ȃX�e�[�^�X�|�C���g
    public int needspcount = 0;                //���񂩂ɂ����needsp���₷���߂̂��
    public int soubi = 1;
    public bool first = true;

    public bool sky = true;�@�@�@�@�@�@�@�@�@ //�V��_�a�ɂ��邱��
    public bool save = false;                 //�Z�[�u�|�C���g�ɂ��邱��
    public float healpotion = 0;        //�q�[���|�[�V����
}
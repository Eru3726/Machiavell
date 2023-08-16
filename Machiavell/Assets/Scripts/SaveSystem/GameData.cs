using UnityEngine;
//�Q�[�����ŕێ����Ă����������ځi�����̒l�͔C�Ӂj

public class GameData
{
    public static KeyCode rightkey = KeyCode.D;
    public static string righttx = "D";
    public static KeyCode leftkey = KeyCode.A;
    public static string lefttx = "A";
    public static KeyCode jumpkey = KeyCode.Space;
    public static string jumptx = "Space";
    public static KeyCode attackkey = KeyCode.Mouse0;
    public static string attacktx = "Mouse0";
    public static KeyCode dashkey = KeyCode.LeftShift;
    public static string dashtx = "LeftShift";
    public static KeyCode healkey = KeyCode.H;
    public static string healtx = "H";
    public static KeyCode menukey = KeyCode.Escape;
    public static string menutx = "Escape";
    public static KeyCode downkey = KeyCode.S;
    public static string downtx = "S";
    public static KeyCode interactkey = KeyCode.E;
    public static string interacttx = "E";

    public static int[] inventoryWeapon = new int[10];

    public static int[] weaponRarity = new int[10];

    public static int[] weaponHp = new int[10];
    public static int[] weaponneedHp = new int[10];
    public static int[] weaponhpcount = new int[10];

    public static int[] weaponStamina = new int[10];
    public static int[] weaponneedStamina = new int[10];
    public static int[] weaponStaminacount = new int[10];

    public static int[] weaponAttack = new int[10];
    public static int[] weaponneedAttack = new int[10];
    public static int[] weaponAttackcount = new int[10];

    public static int[] weaponGuard = new int[10];
    public static int[] weaponneedGuard = new int[10];
    public static int[] weaponGuardcount = new int[10];

    public static int[] weaponLuck = new int[10];
    public static int[] weaponneedLuck = new int[10];
    public static int[] weaponLuckcount = new int[10];

    public static int[] weaponLevel = new int[10];

    public static int playerexp = 0;       //�o���l
    public static int playerlevel = 1;            //�v���C���[�̃��x��
    public static int needEXP = 1;�@�@�@�@�@�@�@//���x���A�b�v�ɕK�v�Ȍo���l
    public static int needEXPcount = 0;            //���񂩂Ɉ�񃌃x���������邽�߂ɕK�v�Ȍo���l�𑝂₷
    public static int playerhp = 100;�@�@�@�@�@�@�@�@�@�@//�v���C���[�̗̑�
    public static int playerhpnow = 110;                //�v���C���[�̌��݂̗̑�
    public static int playerstamina = 100;�@�@�@�@�@�@�@�@�@ //�v���C���[�̃X�^�~�i
    public static int playeroffence = 1;                   //�v���C���[�̍U��
    public static int playerdeffence = 1;                   //�v���C���[�̖h��
    public static int playerluck = 1;                   //�v���C���[�̉^
    public static int playerstatuspoint = 0;                   //�v���C���[�̃X�e�[�^�X�|�C���g
    public static int playerneedsp = 1;               //�X�e�[�^�X�����ɕK�v�ȃX�e�[�^�X�|�C���g
    public static int needspcount = 0;                //���񂩂ɂ����needsp���₷���߂̂��
    public static int soubi = 1;                   //�������Ă镐��P����10��
    public static bool first = true;                   //��ԍŏ��ɕ���Ƃ��F�X���邽�߂̂��

    public static bool sky = true;                    //�V��_�a�ɂ��邱��
    public static bool save = false;                  //�Z�[�u�|�C���g�ɂ��邱��
    public static float sound = 50;          //����
    public static float healpotion = 0;        //�q�[���|�[�V����
}

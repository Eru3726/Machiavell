using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slotdrop : MonoBehaviour
{
    [SerializeField]
    private DataBase db;

    public GameObject parent;
    public WeaponData wd; 
    public slotstar ss;
    public Slotcontroll sc;
    public bool read = false;
    public GameObject prefab;
    public GameObject pos;
    public GameObject pos1;
    public GameObject pos2;
    public GameObject pos3;
    public GameObject pos4;
    public GameObject pos5;
    public GameObject pos6;
    public GameObject pos7;
    public GameObject pos8;
    public GameObject pos9;
    public GameObject pos10;
    public int rand;                       //乱数


    //public PlayerStatus ps;                 //ステータス呼び出し

    public int enemyType;                  //武器の種類ID
                                           //0…ステッキ
                                           //1…大剣
                                           //2…大斧
                                           //3…ハンマー
                                           //4…剣
                                           //5…手斧
                                           //6…槍
                                           //7…レイピア
                                           //8…弓
                                           //9…クロスボウ
                                           //オブジェクトの生成位置
    Vector3 position = new Vector3(0f, 0f, 0);
    Vector3 position1 = new Vector3(-11.04f, -8f, 10f);
    Vector3 position2 = new Vector3(-8.16f, -8f, 10);
    Vector3 position3 = new Vector3(-5.28f, -8f, 10);
    Vector3 position4 = new Vector3(-2.4f, -8f, 10);
    Vector3 position5 = new Vector3(0.48f, -8f, 10);
    Vector3 position6 = new Vector3(3.36f, -8f, 10);
    Vector3 position7 = new Vector3(6.24f, -8f, 10);
    Vector3 position8 = new Vector3(9.12f, -8f, 10);
    Vector3 position9 = new Vector3(12f, -8f, 10);
    Vector3 position10 = new Vector3(14.88f, -8f, 10);

    public int weaponID;
    void Start()
    {
        
    }
    void Update()
    {

    }

    public void OnClick()
    {
        rand = Random.Range(1, 101);
        Debug.Log(rand);
        Drop();
    }

    public void First()
    {
        prefab = Resources.Load<GameObject>("Prefabs/LargeSword/LargeSword1");
        weaponID = 11;
        Debug.Log("★1の大剣を入手しました");
        GameData.inventoryWeapon1 = weaponID;
        Debug.Log("drop1");
        GameData.soubi = 1;
        Debug.Log("インベントリ1番に" + weaponID + "が入った！");
        GameData.weaponRarity1 = db.weapons[weaponID].weaponRarity;
        GameData.weaponHp1 = db.weapons[weaponID].weaponHp;
        GameData.weaponStamina1 = db.weapons[weaponID].weaponStamina;
        GameData.weaponAttack1 = db.weapons[weaponID].weaponAttack;
        GameData.weaponGuard1 = db.weapons[weaponID].weaponGuard;
        GameData.weaponLuck1 = db.weapons[weaponID].weaponLuck;
        GameData.weaponLevel1 = db.weapons[weaponID].weaponLevel;
        Debug.Log("データベース参照");
        Debug.Log("first" + GameData.first);
        GameData.first = false;
    }

    //ドロップ
    public void Drop()
    {
        //レア5
        rand -= DHierarchy.hierarchy * 5;
        if (rand <= 1)
        {
            if (enemyType == 1)
            {
                //1…大剣
                prefab = Resources.Load<GameObject>("Prefabs/LargeSword/LargeSword5");
                weaponID = 51;
                Debug.Log("固有大剣を入手しました");
            }
            else if (enemyType == 2)
            {
                //2…大斧
                prefab = Resources.Load<GameObject>("Prefabs/LargeAxe/LargeAxe5");
                weaponID = 52;
                Debug.Log("固有大斧を入手しました");
            }
            else if (enemyType == 3)
            {
                //3…ハンマー
                prefab = Resources.Load<GameObject>("Prefabs/Hammer/Hammer5");
                weaponID = 53;
                Debug.Log("固有ハンマーを入手しました");
            }
            else if (enemyType == 4)
            {
                //4…剣
                prefab = Resources.Load<GameObject>("Prefabs/Sword/Sword5");
                weaponID = 54;
                Debug.Log("固有剣を入手しました");
            }
            else if (enemyType == 5)
            {
                //5…手斧
                prefab = Resources.Load<GameObject>("Prefabs/Axe/Axe5");
                weaponID = 55;
                Debug.Log("固有手斧を入手しました");
            }
            else if (enemyType == 6)
            {
                //6…槍
                prefab = Resources.Load<GameObject>("Prefabs/Spear/Spear5");
                weaponID = 56;
                Debug.Log("固有槍を入手しました");
            }
            else if (enemyType == 7)
            {
                //7…レイピア
                prefab = Resources.Load<GameObject>("Prefabs/Rapier/Rapier5");
                weaponID = 57;
                Debug.Log("固有レイピアを入手しました");
            }
        }
        else if (rand <= 11)
        {
            //レア4
            rand = Random.Range(1, 7);
            if (rand == 1)
            {
                //1…大剣
                prefab = Resources.Load<GameObject>("Prefabs/LargeSword/LargeSword4");
                weaponID = 41;
                Debug.Log("★4の大剣を入手しました");
            }
            else if (rand == 2)
            {
                //2…大斧
                prefab = Resources.Load<GameObject>("Prefabs/LargeAxe/LargeAxe4");
                weaponID = 42;
                Debug.Log("★4の大斧を入手しました");
            }
            else if (rand == 3)
            {
                //3…ハンマー
                prefab = Resources.Load<GameObject>("Prefabs/Hammer/Hammer4");
                weaponID = 43;
                Debug.Log("★4のハンマーを入手しました");
            }
            else if (rand == 4)
            {
                //4…剣
                prefab = Resources.Load<GameObject>("Prefabs/Sword/Sword4");
                weaponID = 44;
                Debug.Log("★4の剣を入手しました");
            }
            else if (rand == 5)
            {
                //5…手斧
                prefab = Resources.Load<GameObject>("Prefabs/Axe/Axe4");
                weaponID = 45;
                Debug.Log("★4の手斧を入手しました");
            }
            else if (rand == 6)
            {
                //6…槍
                prefab = Resources.Load<GameObject>("Prefabs/Spear/Spear4");
                weaponID = 46;
                Debug.Log("★4の槍を入手しました");
            }
            else if (rand == 7)
            {
                //7…レイピア
                prefab = Resources.Load<GameObject>("Prefabs/Rapier/Rapier4");
                weaponID = 47;
                Debug.Log("★4のレイピアを入手しました");
            }
        }
        else if (rand <= 31)
        {
            //レア3
            rand = Random.Range(1, 7);
            if (rand == 1)
            {
                //1…大剣
                prefab = Resources.Load<GameObject>("Prefabs/LargeSword/LargeSword3");
                weaponID = 31;
                Debug.Log("★3の大剣を入手しました");
            }
            else if (rand == 2)
            {
                //2…大斧
                prefab = Resources.Load<GameObject>("Prefabs/LargeAxe/LargeAxe3");
                weaponID = 32;
                Debug.Log("★3の大斧を入手しました");
            }
            else if (rand == 3)
            {
                //3…ハンマー
                prefab = Resources.Load<GameObject>("Prefabs/Hammer/Hammer3");
                weaponID = 33;
                Debug.Log("★3のハンマーを入手しました");
            }
            else if (rand == 4)
            {
                //4…剣
                prefab = Resources.Load<GameObject>("Prefabs/Sword/Sword3");
                weaponID = 34;
                Debug.Log("★3の剣を入手しました");
            }
            else if (rand == 5)
            {
                //5…手斧
                prefab = Resources.Load<GameObject>("Prefabs/Axe/Axe3");
                weaponID = 35;
                Debug.Log("★3の手斧を入手しました");
            }
            else if (rand == 6)
            {
                //6…槍
                prefab = Resources.Load<GameObject>("Prefabs/Spear/Spear3");
                weaponID = 36;
                Debug.Log("★3の槍を入手しました");
            }
            else if (rand == 7)
            {
                //7…レイピア
                prefab = Resources.Load<GameObject>("Prefabs/Rapier/Rapier3");
                weaponID = 37;
                Debug.Log("★3のレイピアを入手しました");
            }
        }
        else if (rand <= 61)
        {
            //レア2
            rand = Random.Range(1, 7);
            if (rand == 1)
            {
                //1…大剣
                prefab = Resources.Load<GameObject>("Prefabs/LargeSword/LargeSword2");
                weaponID = 21;
                Debug.Log("★2の大剣を入手しました");
            }
            else if (rand == 2)
            {
                //2…大斧
                prefab = Resources.Load<GameObject>("Prefabs/LargeAxe/LargeAxe2");
                weaponID = 22;
                Debug.Log("★2の大斧を入手しました");
            }
            else if (rand == 3)
            {
                //3…ハンマー
                prefab = Resources.Load<GameObject>("Prefabs/Hammer/Hammer2");
                weaponID = 23;
                Debug.Log("★2のハンマーを入手しました");
            }
            else if (rand == 4)
            {
                //4…剣
                prefab = Resources.Load<GameObject>("Prefabs/Sword/Sword2");
                weaponID = 24;
                Debug.Log("★2の剣を入手しました");
            }
            else if (rand == 5)
            {
                //5…手斧
                prefab = Resources.Load<GameObject>("Prefabs/Axe/Axe2");
                weaponID = 25;
                Debug.Log("★2の手斧を入手しました");
            }
            else if (rand == 6)
            {
                //6…槍
                prefab = Resources.Load<GameObject>("Prefabs/Spear/Spear2");
                weaponID = 26;
                Debug.Log("★2の槍を入手しました");
            }
            else if (rand == 7)
            {
                //7…レイピア
                prefab = Resources.Load<GameObject>("Prefabs/Rapier/Rapier2");
                weaponID = 27;
                Debug.Log("★2のレイピアを入手しました");
            }
        }
        else
        {
            //レア1
            rand = Random.Range(1, 7);
            if (rand == 1)
            {
                //1…大剣
                prefab = Resources.Load<GameObject>("Prefabs/LargeSword/LargeSword1");
                weaponID = 11;
                Debug.Log("★1の大剣を入手しました");
            }
            else if (rand == 2)
            {
                //2…大斧
                prefab = Resources.Load<GameObject>("Prefabs/LargeAxe/LargeAxe1");
                weaponID = 12;
                Debug.Log("★1の大斧を入手しました");
            }
            else if (rand == 3)
            {
                //3…ハンマー
                prefab = Resources.Load<GameObject>("Prefabs/Hammer/Hammer1");
                weaponID = 13;
                Debug.Log("★1のハンマーを入手しました");
            }
            else if (rand == 4)
            {
                //4…剣
                prefab = Resources.Load<GameObject>("Prefabs/Sword/Sword1");
                weaponID = 14;
                Debug.Log("★1の剣を入手しました");
            }
            else if (rand == 5)
            {
                //5…手斧
                prefab = Resources.Load<GameObject>("Prefabs/Axe/Axe1");
                weaponID = 15;
                Debug.Log("★1の手斧を入手しました");
            }
            else if (rand == 6)
            {
                //6…槍
                prefab = Resources.Load<GameObject>("Prefabs/Spear/Spear1");
                weaponID = 16;
                Debug.Log("★1の槍を入手しました");
            }
            else if (rand == 7)
            {
                //7…レイピア
                prefab = Resources.Load<GameObject>("Prefabs/Rapier/Rapier1");
                weaponID = 17;
                Debug.Log("★1のレイピアを入手しました");
            }
        }
        WInventory();
    }

    public void WInventory()
    {
        Debug.Log("prefab" + prefab);
        if (prefab != null)
        {
            if (read == true)
            {
                //Debug.Log(GameData.inventoryWeapon1);
                //Debug.Log(GameData.inventoryWeapon2);
                //Debug.Log(GameData.inventoryWeapon3);
                //Debug.Log(GameData.inventoryWeapon4);
                //Debug.Log(GameData.inventoryWeapon5);
                //Debug.Log(GameData.inventoryWeapon6);
                //Debug.Log(GameData.inventoryWeapon7);
                //Debug.Log(GameData.inventoryWeapon8);
                //Debug.Log(GameData.inventoryWeapon9);
                //Debug.Log(GameData.inventoryWeapon10);
                if (GameData.inventoryWeapon1 != 999 && GameData.inventoryWeapon1 != 0 && !pos1)
                {
                    position = position1;
                    pos = Instantiate(prefab, position, Quaternion.identity);
                    pos.transform.localScale -= new Vector3(-0.5f, -0.5f, 0);
                    pos.transform.localPosition = position;
                    pos1 = pos;
                    sc.buki1 = pos1;
                    Debug.Log("weaponID1 " + weaponID);
                    GameData.inventoryWeapon1 = weaponID;
                    Debug.Log("read1");
                }
                else if (GameData.inventoryWeapon2 != 999 && GameData.inventoryWeapon2 != 0 && !pos2)
                {
                    position = position2;
                    pos = Instantiate(prefab, position, Quaternion.identity);
                    pos.transform.localScale -= new Vector3(-0.5f, -0.5f, 0);
                    pos.transform.localPosition = position;
                    pos2 = pos;
                    sc.buki2 = pos2;
                    Debug.Log("weaponID2 " + weaponID);
                    GameData.inventoryWeapon2 = weaponID;
                    Debug.Log("read2");
                }
                else if (GameData.inventoryWeapon3 != 999 && GameData.inventoryWeapon3 != 0 && !pos3)
                {
                    position = position3;
                    pos = Instantiate(prefab, position, Quaternion.identity);
                    pos.transform.localScale -= new Vector3(-0.5f, -0.5f, 0);
                    pos.transform.localPosition = position;
                    pos3 = pos;
                    sc.buki3 = pos3;
                    Debug.Log("weaponID3 " + weaponID);
                    GameData.inventoryWeapon3 = weaponID;
                    Debug.Log("read3");
                }
                else if (GameData.inventoryWeapon4 != 999 && GameData.inventoryWeapon4 != 0 && !pos4)
                {
                    position = position4;
                    pos = Instantiate(prefab, position, Quaternion.identity);
                    pos.transform.localScale -= new Vector3(-0.5f, -0.5f, 0);
                    pos.transform.localPosition = position;
                    pos4 = pos;
                    sc.buki4 = pos4;
                    Debug.Log("weaponID4 " + weaponID);
                    GameData.inventoryWeapon4 = weaponID;
                    Debug.Log("read4");
                }
                else if (GameData.inventoryWeapon5 != 999 && GameData.inventoryWeapon5 != 0 && !pos5)
                {
                    position = position5;
                    pos = Instantiate(prefab, position, Quaternion.identity);
                    pos.transform.localScale -= new Vector3(-0.5f, -0.5f, 0);
                    pos.transform.localPosition = position;
                    pos5 = pos;
                    sc.buki5 = pos5;
                    Debug.Log("weaponID5 " + weaponID);
                    GameData.inventoryWeapon5 = weaponID;
                    Debug.Log("read5");
                }
                else if (GameData.inventoryWeapon6 != 999 && GameData.inventoryWeapon6 != 0 && !pos6)
                {
                    position = position6;
                    pos = Instantiate(prefab, position, Quaternion.identity);
                    pos.transform.localScale -= new Vector3(-0.5f, -0.5f, 0);
                    pos.transform.localPosition = position;
                    pos6 = pos;
                    sc.buki6 = pos6;
                    Debug.Log("weaponID6 " + weaponID);
                    GameData.inventoryWeapon6 = weaponID;
                    Debug.Log("read6");
                }
                else if (GameData.inventoryWeapon7 != 999 && GameData.inventoryWeapon7 != 0 && !pos7)
                {
                    position = position7;
                    pos = Instantiate(prefab, position, Quaternion.identity);
                    pos.transform.localScale -= new Vector3(-0.5f, -0.5f, 0);
                    pos.transform.localPosition = position;
                    pos7 = pos;
                    sc.buki7 = pos7;
                    Debug.Log("weaponID7 " + weaponID);
                    GameData.inventoryWeapon7 = weaponID;
                    Debug.Log("read7");
                }
                else if (GameData.inventoryWeapon8 != 999 && GameData.inventoryWeapon8 != 0 && !pos8)
                {
                    position = position8;
                    pos = Instantiate(prefab, position, Quaternion.identity);
                    pos.transform.localScale -= new Vector3(-0.5f, -0.5f, 0);
                    pos.transform.localPosition = position;
                    pos8 = pos;
                    sc.buki8 = pos8;
                    Debug.Log("weaponID8 " + weaponID);
                    GameData.inventoryWeapon8 = weaponID;
                    Debug.Log("read8");
                }
                else if (GameData.inventoryWeapon9 != 999 && GameData.inventoryWeapon9 != 0 && !pos9)
                {
                    position = position9;
                    pos = Instantiate(prefab, position, Quaternion.identity);
                    pos.transform.localScale -= new Vector3(-0.5f, -0.5f, 0);
                    pos.transform.localPosition = position;
                    pos9 = pos;
                    sc.buki9 = pos9;
                    Debug.Log("weaponID9 " + weaponID);
                    GameData.inventoryWeapon9 = weaponID;
                    Debug.Log("read9");
                }
                else if (GameData.inventoryWeapon10 != 999 && GameData.inventoryWeapon10 != 0 && !pos10)
                {
                    position = position10;
                    pos = Instantiate(prefab, position, Quaternion.identity);
                    pos.transform.localScale -= new Vector3(-0.5f, -0.5f, 0);
                    pos.transform.localPosition = position;
                    pos10 = pos;
                    sc.buki10 = pos10;
                    Debug.Log("weaponID10 " + weaponID);
                    GameData.inventoryWeapon10 = weaponID;
                    Debug.Log("read10");
                }
                read = false;
            }
            else if (!pos1)
            {
                position = position1;
                pos = Instantiate(prefab, position, Quaternion.identity);
                pos.transform.localScale -= new Vector3(-0.5f, -0.5f, 0);
                pos.transform.localPosition = position;
                pos1 = pos;
                sc.buki1 = pos1;
                GameData.inventoryWeapon1 = weaponID;
                Debug.Log("drop1");
            }
            else if (!pos2)
            {
                position = position2;
                pos = Instantiate(prefab, position, Quaternion.identity);
                pos.transform.localScale -= new Vector3(-0.5f, -0.5f, 0);
                pos.transform.localPosition = position;
                pos2 = pos;
                sc.buki2 = pos2;
                GameData.inventoryWeapon2 = weaponID;
                Debug.Log("drop2");
            }
            else if (!pos3)
            {
                position = position3;
                pos = Instantiate(prefab, position, Quaternion.identity);
                pos.transform.localScale -= new Vector3(-0.5f, -0.5f, 0);
                pos.transform.localPosition = position;
                pos3 = pos;
                sc.buki3 = pos3;
                GameData.inventoryWeapon3 = weaponID;
                Debug.Log("drop3");
            }
            else if (!pos4)
            {
                position = position4;
                pos = Instantiate(prefab, position, Quaternion.identity);
                pos.transform.localScale -= new Vector3(-0.5f, -0.5f, 0);
                pos.transform.localPosition = position;
                pos4 = pos;
                sc.buki4 = pos4;
                GameData.inventoryWeapon4 = weaponID;
                Debug.Log("drop4");
            }
            else if (!pos5)
            {
                position = position5;
                pos = Instantiate(prefab, position, Quaternion.identity);
                pos.transform.localScale -= new Vector3(-0.5f, -0.5f, 0);
                pos.transform.localPosition = position;
                pos5 = pos;
                sc.buki5 = pos5;
                GameData.inventoryWeapon5 = weaponID;
                Debug.Log("drop5");
            }
            else if (!pos6)
            {
                position = position6;
                pos = Instantiate(prefab, position, Quaternion.identity);
                pos.transform.localScale -= new Vector3(-0.5f, -0.5f, 0);
                pos.transform.localPosition = position;
                pos6 = pos;
                sc.buki6 = pos6;
                GameData.inventoryWeapon6 = weaponID;
                Debug.Log("drop6");
            }
            else if (!pos7)
            {
                position = position7;
                pos = Instantiate(prefab, position, Quaternion.identity);
                pos.transform.localScale -= new Vector3(-0.5f, -0.5f, 0);
                pos.transform.localPosition = position;
                pos7 = pos;
                sc.buki7 = pos7;
                GameData.inventoryWeapon7 = weaponID;
                Debug.Log("drop7");
            }
            else if (!pos8)
            {
                position = position8;
                pos = Instantiate(prefab, position, Quaternion.identity);
                pos.transform.localScale -= new Vector3(-0.5f, -0.5f, 0);
                pos.transform.localPosition = position;
                pos8 = pos;
                sc.buki8 = pos8;
                GameData.inventoryWeapon8 = weaponID;
                Debug.Log("drop8");
            }
            else if (!pos9)
            {
                position = position9;
                pos = Instantiate(prefab, position, Quaternion.identity);
                pos.transform.localScale -= new Vector3(-0.5f, -0.5f, 0);
                pos.transform.localPosition = position;
                pos9 = pos;
                sc.buki9 = pos9;
                GameData.inventoryWeapon9 = weaponID;
                Debug.Log("drop9");
            }
            else if (!pos10)
            {
                position = position10;
                pos = Instantiate(prefab, position, Quaternion.identity);
                pos.transform.localScale -= new Vector3(-0.5f, -0.5f, 0);
                pos.transform.localPosition = position;
                pos10 = pos;
                sc.buki10 = pos10;
                GameData.inventoryWeapon10 = weaponID;
                Debug.Log("drop10");
            }
            else
            {
                Debug.Log("インベントリがいっぱいです");
            }
            pos.transform.parent = parent.transform;
            pos.transform.localPosition = position;
            pos.SetActive(false);
        }
    }
}

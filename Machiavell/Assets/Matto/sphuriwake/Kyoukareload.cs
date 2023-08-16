using UnityEngine;

public class Kyoukareload : MonoBehaviour
{
    public DropWeapon dw;
    public WeaponData wd;
    public GameObject sannsyouscripts;
    private GameObject sannsyou;
    private float dcount;

    public void KyoukaReload()
    {
        int[] inventoryWeapon = new int[10] { GameData.inventoryWeapon[0], GameData.inventoryWeapon[1], GameData.inventoryWeapon[2], GameData.inventoryWeapon[3], GameData.inventoryWeapon[4], GameData.inventoryWeapon[5], GameData.inventoryWeapon[6], GameData.inventoryWeapon[7], GameData.inventoryWeapon[8], GameData.inventoryWeapon[9] };

        for (int i = 0; i < 10; i++)
        {
            dw.weaponID = inventoryWeapon[i];

            //Åö5ïêäÌ
            if (inventoryWeapon[i] == 51)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/LargeSword/LargeSword5");
                wd.weaponDataID[i] = 4;
            }
            else if (inventoryWeapon[i] == 52)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/LargeAxe/LargeAxe5");
                wd.weaponDataID[i] = 9;
            }
            else if (inventoryWeapon[i] == 53)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/Hammer/Hammer5");
                wd.weaponDataID[i] = 14;
            }
            else if (inventoryWeapon[i] == 54)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/Sword/Sword5");
                wd.weaponDataID[i] = 19;
            }
            else if (inventoryWeapon[i] == 55)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/Axe/Axe5");
                wd.weaponDataID[i] = 24;
            }
            else if (inventoryWeapon[i] == 56)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/Spear/Spear5");
                wd.weaponDataID[i] = 29;
            }
            else if (inventoryWeapon[i] == 57)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/Rapier/Rapier5");
                wd.weaponDataID[i] = 34;
            }

            //Åö4ïêäÌ
            else if (inventoryWeapon[i] == 41)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/LargeSword/LargeSword4");
                wd.weaponDataID[i] = 3;
            }
            else if (inventoryWeapon[i] == 42)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/LargeAxe/LargeAxe4");
                wd.weaponDataID[i] = 8;
            }
            else if (inventoryWeapon[i] == 43)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/Hammer/Hammer4");
                wd.weaponDataID[i] = 13;
            }
            else if (inventoryWeapon[i] == 44)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/Sword/Sword4");
                wd.weaponDataID[i] = 18;
            }
            else if (inventoryWeapon[i] == 45)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/Axe/Axe4");
                wd.weaponDataID[i] = 23;
            }
            else if (inventoryWeapon[i] == 46)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/Spear/Spear4");
                wd.weaponDataID[i] = 28;
            }
            else if (inventoryWeapon[i] == 47)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/Rapier/Rapier4");
                wd.weaponDataID[i] = 33;
            }

            //Åö3ïêäÌ
            else if (inventoryWeapon[i] == 31)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/LargeSword/LargeSword3");
                wd.weaponDataID[i] = 2;
            }
            else if (inventoryWeapon[i] == 32)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/LargeAxe/LargeAxe3");
                wd.weaponDataID[i] = 7;
            }
            else if (inventoryWeapon[i] == 33)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/Hammer/Hammer3");
                wd.weaponDataID[i] = 12;
            }
            else if (inventoryWeapon[i] == 34)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/Sword/Sword3");
                wd.weaponDataID[i] = 17;
            }
            else if (inventoryWeapon[i] == 35)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/Axe/Axe3");
                wd.weaponDataID[i] = 22;
            }
            else if (inventoryWeapon[i] == 36)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/Spear/Spear3");
                wd.weaponDataID[i] = 27;
            }
            else if (inventoryWeapon[i] == 37)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/Rapier/Rapier3");
                wd.weaponDataID[i] = 32;
            }

            //Åö2ïêäÌ
            else if (inventoryWeapon[i] == 21)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/LargeSword/LargeSword2");
                wd.weaponDataID[i] = 1;
            }
            else if (inventoryWeapon[i] == 22)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/LargeAxe/LargeAxe2");
                wd.weaponDataID[i] = 6;
            }
            else if (inventoryWeapon[i] == 23)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/Hammer/Hammer2");
                wd.weaponDataID[i] = 11;
            }
            else if (inventoryWeapon[i] == 24)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/Sword/Sword2");
                wd.weaponDataID[i] = 16;
            }
            else if (inventoryWeapon[i] == 25)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/Axe/Axe2");
                wd.weaponDataID[i] = 21;
            }
            else if (inventoryWeapon[i] == 26)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/Spear/Spear2");
                wd.weaponDataID[i] = 26;
            }
            else if (inventoryWeapon[i] == 27)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/Rapier/Rapier2");
                wd.weaponDataID[i] = 31;
            }

            //Åö1ïêäÌ
            else if (inventoryWeapon[i] == 11)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/LargeSword/LargeSword1");
                wd.weaponDataID[i] = 0;
            }
            else if (inventoryWeapon[i] == 12)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/LargeAxe/LargeAxe1");
                wd.weaponDataID[i] = 5;
            }
            else if (inventoryWeapon[i] == 13)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/Hammer/Hammer1");
                wd.weaponDataID[i] = 10;
            }
            else if (inventoryWeapon[i] == 14)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/Sword/Sword1");
                wd.weaponDataID[i] = 15;
            }
            else if (inventoryWeapon[i] == 15)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/Axe/Axe1");
                wd.weaponDataID[i] = 20;
            }
            else if (inventoryWeapon[i] == 16)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/Spear/Spear1");
                wd.weaponDataID[i] = 25;
            }
            else if (inventoryWeapon[i] == 17)
            {
                dw.prefab = Resources.Load<GameObject>("Prefabs/Rapier/Rapier1");
                wd.weaponDataID[i] = 30;
            }

            else
            {
                dw.prefab = null;
                dw.weaponID = 0;
                wd.weaponDataID[i] = 999;
            }
            //if (i == 1)
            //{
            //    GameData.inventoryWeapon1 = 0;
            //}
            //else if (i == 2)
            //{
            //    GameData.inventoryWeapon2 = 0;
            //}
            //else if (i == 3)
            //{
            //    GameData.inventoryWeapon3 = 0;
            //}
            //else if (i == 4)
            //{
            //    GameData.inventoryWeapon4 = 0;
            //}
            //else if (i == 5)
            //{
            //    GameData.inventoryWeapon5 = 0;
            //}
            //else if (i == 6)
            //{
            //    GameData.inventoryWeapon6 = 0;
            //}
            //else if (i == 7)
            //{
            //    GameData.inventoryWeapon7 = 0;
            //}
            //else if (i == 8)
            //{
            //    GameData.inventoryWeapon8 = 0;
            //}
            //else if (i == 9)
            //{
            //    GameData.inventoryWeapon9 = 0;
            //}
            //else if (i == 10)
            //{
            //    GameData.inventoryWeapon10 = 0;
            //}
            dw.read = true;
            dw.WInventory();
            //wd.InventoryWeaponData();
        }
    }

    public void KyoukaDelete()
    {
        Destroy(dw.pos1);
        Destroy(dw.pos2);
        Destroy(dw.pos3);
        Destroy(dw.pos4);
        Destroy(dw.pos5);
        Destroy(dw.pos6);
        Destroy(dw.pos7);
        Destroy(dw.pos8);
        Destroy(dw.pos9);
        Destroy(dw.pos10);

        dw.pos1 = null;
        dw.pos2 = null;
        dw.pos3 = null;
        dw.pos4 = null;
        dw.pos5 = null;
        dw.pos6 = null;
        dw.pos7 = null;
        dw.pos8 = null;
        dw.pos9 = null;
        dw.pos10 = null;

        KyoukaReload();
    }

    public void destroyKyouka()
    {
        sannsyou = sannsyouscripts.GetComponent<Kyoukasannsyou>().sannsyou;


        dcount = 0;
        if (dw.pos2)
        {
            dcount += 1;
        }
        if (dw.pos3)
        {
            dcount += 1;
        }
        if (dw.pos4)
        {
            dcount += 1;
        }
        if (dw.pos5)
        {
            dcount += 1;
        }
        if (dw.pos6)
        {
            dcount += 1;
        }
        if (dw.pos7)
        {
            dcount += 1;
        }
        if (dw.pos8)
        {
            dcount += 1;
        }
        if (dw.pos9)
        {
            dcount += 1;
        }
        if (dw.pos10)
        {
            dcount += 1;
        }
        if (dw.pos1)
        {
            dcount += 1;
        }

        if (dcount <= 1)
        {
            Debug.Log("ïêäÌÇ™Ç»Ç≠Ç»ÇÈÇ©ÇÁÉ_ÉÅ");
        }
        else
        {
            if (dw.pos1 == sannsyou)
            {
                Destroy(dw.pos1);
                dw.pos1 = null;
                GameData.inventoryWeapon[0] = 999;
            }
            else if (dw.pos2 == sannsyou)
            {
                Destroy(dw.pos2);
                dw.pos2 = null;
                GameData.inventoryWeapon[1] = 999;
            }
            else if (dw.pos3 == sannsyou)
            {
                Destroy(dw.pos3);
                dw.pos3 = null;
                GameData.inventoryWeapon[2] = 999;
            }
            else if (dw.pos4 == sannsyou)
            {
                Destroy(dw.pos4);
                dw.pos4 = null;
                GameData.inventoryWeapon[3] = 999;
            }
            else if (dw.pos5 == sannsyou)
            {
                Destroy(dw.pos5);
                dw.pos5 = null;
                GameData.inventoryWeapon[4] = 999;
            }
            else if (dw.pos6 == sannsyou)
            {
                Destroy(dw.pos6);
                dw.pos6 = null;
                GameData.inventoryWeapon[5] = 999;
            }
            else if (dw.pos7 == sannsyou)
            {
                Destroy(dw.pos7);
                dw.pos7 = null;
                GameData.inventoryWeapon[6] = 999;
            }
            else if (dw.pos8 == sannsyou)
            {
                Destroy(dw.pos8);
                dw.pos8 = null;
                GameData.inventoryWeapon[7] = 999;
            }
            else if (dw.pos9 == sannsyou)
            {
                Destroy(dw.pos9);
                dw.pos9 = null;
                GameData.inventoryWeapon[8] = 999;
            }
            else if (dw.pos10 == sannsyou)
            {
                Destroy(dw.pos10);
                dw.pos10 = null;
                GameData.inventoryWeapon[9] = 999;
            }
        }
        
    }
}

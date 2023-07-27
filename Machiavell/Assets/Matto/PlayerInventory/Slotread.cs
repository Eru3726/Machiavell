using UnityEngine;

public class Slotread : MonoBehaviour
{
    public Slotdrop sw;
    public Slotsannsyou sannsyouscripts;
    public WeaponData wd;
    public Weaponsoubi wsoubi;
    private GameObject sannsyou;
    private float dcount;
    public bool drop = true;
    public void WeaponReload()
    {
        int[] inventoryWeapon = new int[10] { GameData.inventoryWeapon1, GameData.inventoryWeapon2, GameData.inventoryWeapon3, GameData.inventoryWeapon4, GameData.inventoryWeapon5, GameData.inventoryWeapon6, GameData.inventoryWeapon7, GameData.inventoryWeapon8, GameData.inventoryWeapon9, GameData.inventoryWeapon10 };

        for (int i = 0; i < 10; i++)
        {
            sw.weaponID = inventoryWeapon[i];
            Debug.Log("inventryweapon"+i+inventoryWeapon[i]);
            //Åö5ïêäÌ
            if (inventoryWeapon[i] == 51)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/LargeSword/LargeSword5");
                wd.weaponDataID[i] = 4;
            }
            else if (inventoryWeapon[i] == 52)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/LargeAxe/LargeAxe5");
                wd.weaponDataID[i] = 9;
            }
            else if (inventoryWeapon[i] == 53)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/Hammer/Hammer5");
                wd.weaponDataID[i] = 14;
            }
            else if (inventoryWeapon[i] == 54)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/Sword/Sword5");
                wd.weaponDataID[i] = 19;
            }
            else if (inventoryWeapon[i] == 55)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/Axe/Axe5");
                wd.weaponDataID[i] = 24;
            }
            else if (inventoryWeapon[i] == 56)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/Spear/Spear5");
                wd.weaponDataID[i] = 29;
            }
            else if (inventoryWeapon[i] == 57)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/Rapier/Rapier5");
                wd.weaponDataID[i] = 34;
            }

            //Åö4ïêäÌ
            else if (inventoryWeapon[i] == 41)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/LargeSword/LargeSword4");
                wd.weaponDataID[i] = 3;
                Debug.Log("largesword4");
            }
            else if (inventoryWeapon[i] == 42)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/LargeAxe/LargeAxe4");
                wd.weaponDataID[i] = 8;
                Debug.Log("largeaxe4");
            }
            else if (inventoryWeapon[i] == 43)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/Hammer/Hammer4");
                wd.weaponDataID[i] = 13;
                Debug.Log("hammer4");
            }
            else if (inventoryWeapon[i] == 44)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/Sword/Sword4");
                wd.weaponDataID[i] = 18;
            }
            else if (inventoryWeapon[i] == 45)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/Axe/Axe4");
                wd.weaponDataID[i] = 23;
            }
            else if (inventoryWeapon[i] == 46)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/Spear/Spear4");
                wd.weaponDataID[i] = 28;
            }
            else if (inventoryWeapon[i] == 47)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/Rapier/Rapier4");
                wd.weaponDataID[i] = 33;
            }

            //Åö3ïêäÌ
            else if (inventoryWeapon[i] == 31)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/LargeSword/LargeSword3");
                wd.weaponDataID[i] = 2;
                Debug.Log("largesword3");
            }
            else if (inventoryWeapon[i] == 32)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/LargeAxe/LargeAxe3");
                wd.weaponDataID[i] = 7;
                Debug.Log("largeaxe3");
            }
            else if (inventoryWeapon[i] == 33)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/Hammer/Hammer3");
                wd.weaponDataID[i] = 12;
                Debug.Log("hammer3");
            }
            else if (inventoryWeapon[i] == 34)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/Sword/Sword3");
                wd.weaponDataID[i] = 17;
            }
            else if (inventoryWeapon[i] == 35)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/Axe/Axe3");
                wd.weaponDataID[i] = 22;
            }
            else if (inventoryWeapon[i] == 36)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/Spear/Spear3");
                wd.weaponDataID[i] = 27;
            }
            else if (inventoryWeapon[i] == 37)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/Rapier/Rapier3");
                wd.weaponDataID[i] = 32;
            }

            //Åö2ïêäÌ
            else if (inventoryWeapon[i] == 21)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/LargeSword/LargeSword2");
                wd.weaponDataID[i] = 1;
                Debug.Log("largesword2");
            }
            else if (inventoryWeapon[i] == 22)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/LargeAxe/LargeAxe2");
                wd.weaponDataID[i] = 6;
                Debug.Log("largeaxe2");
            }
            else if (inventoryWeapon[i] == 23)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/Hammer/Hammer2");
                wd.weaponDataID[i] = 11;
                Debug.Log("hammer2");
            }
            else if (inventoryWeapon[i] == 24)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/Sword/Sword2");
                wd.weaponDataID[i] = 16;
            }
            else if (inventoryWeapon[i] == 25)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/Axe/Axe2");
                wd.weaponDataID[i] = 21;
            }
            else if (inventoryWeapon[i] == 26)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/Spear/Spear2");
                wd.weaponDataID[i] = 26;
            }
            else if (inventoryWeapon[i] == 27)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/Rapier/Rapier2");
                wd.weaponDataID[i] = 31;
            }

            //Åö1ïêäÌ
            else if (inventoryWeapon[i] == 11)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/LargeSword/LargeSword1");
                wd.weaponDataID[i] = 0;
                Debug.Log("largesword1");
            }
            else if (inventoryWeapon[i] == 12)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/LargeAxe/LargeAxe1");
                wd.weaponDataID[i] = 5;
                Debug.Log("largeaxe1");
            }
            else if (inventoryWeapon[i] == 13)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/Hammer/Hammer1");
                wd.weaponDataID[i] = 10;
                Debug.Log("hammer1");
            }
            else if (inventoryWeapon[i] == 14)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/Sword/Sword1");
                wd.weaponDataID[i] = 15;
            }
            else if (inventoryWeapon[i] == 15)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/Axe/Axe1");
                wd.weaponDataID[i] = 20;
            }
            else if (inventoryWeapon[i] == 16)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/Spear/Spear1");
                wd.weaponDataID[i] = 25;
            }
            else if (inventoryWeapon[i] == 17)
            {
                sw.prefab = Resources.Load<GameObject>("Prefabs/Rapier/Rapier1");
                wd.weaponDataID[i] = 30;
            }
            else
            {
                sw.prefab = null;
                sw.weaponID = 0;
                wd.weaponDataID[i] = 999;
            }

            //if(i == 1)
            //{
            //    GameData.inventoryWeapon1 = 0;
            //}
            //else if(i == 2)
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
            sw.read = true;
            sw.WInventory();
            if (wsoubi)
            {
                wsoubi.read = true;
                wsoubi.soubi();
            }
        }
    }

    public void SlotDelete()
    {
        Destroy(sw.pos1);
        Destroy(sw.pos2);
        Destroy(sw.pos3);
        Destroy(sw.pos4);
        Destroy(sw.pos5);
        Destroy(sw.pos6);
        Destroy(sw.pos7);
        Destroy(sw.pos8);
        Destroy(sw.pos9);
        Destroy(sw.pos10);

        sw.pos1 = null;
        sw.pos2 = null;
        sw.pos3 = null;
        sw.pos4 = null;
        sw.pos5 = null;
        sw.pos6 = null;
        sw.pos7 = null;
        sw.pos8 = null;
        sw.pos9 = null;
        sw.pos10 = null;
        WeaponReload();
    }

    public void destroyweapon()
    {
        sannsyou = sannsyouscripts.sannsyou;
        dcount = 0;
        if (sw.pos2)
        {
            dcount += 1;
        }
        if (sw.pos3)
        {
            dcount += 1;
        }
        if (sw.pos4)
        {
            dcount += 1;
        }
        if (sw.pos5)
        {
            dcount += 1;
        }
        if (sw.pos6)
        {
            dcount += 1;
        }
        if (sw.pos7)
        {
            dcount += 1;
        }
        if (sw.pos8)
        {
            dcount += 1;
        }
        if (sw.pos9)
        {
            dcount += 1;
        }
        if (sw.pos10)
        {
            dcount += 1;
        }
        if (sw.pos1)
        {
            dcount += 1;
        }

        if (dcount <= 1)
        {
            Debug.Log("ïêäÌÇ™Ç»Ç≠Ç»ÇÈÇ©ÇÁÉ_ÉÅ");
        }
        else
        {
            if (sw.pos1 == sannsyou)
            {
                if (GameData.soubi == 1)
                {
                    Debug.Log("îjä¸ÇæÇﬂ");
                }
                else
                {
                    Destroy(sw.pos1);
                    sw.pos1 = null;
                    GameData.inventoryWeapon1 = 999;
                }
            }
            else if (sw.pos2 == sannsyou)
            {
                if (GameData.soubi == 2)
                {
                    Debug.Log("îjä¸ÇæÇﬂ");
                }
                else
                {
                    Destroy(sw.pos2);
                    sw.pos2 = null;
                    GameData.inventoryWeapon2 = 999;
                    Debug.Log("ïêäÌÇÕÇ©Å[Ç¢");
                }
            }
            else if (sw.pos3 == sannsyou)
            {
                if (GameData.soubi == 3)
                {
                    Debug.Log("îjä¸ÇæÇﬂ");
                }
                else
                {
                    Destroy(sw.pos3);
                    sw.pos3 = null;
                    GameData.inventoryWeapon3 = 999;
                }
            }
            else if (sw.pos4 == sannsyou)
            {
                if (GameData.soubi == 4)
                {
                    Debug.Log("îjä¸ÇæÇﬂ");
                }
                else
                {
                    Destroy(sw.pos4);
                    sw.pos4 = null;
                    GameData.inventoryWeapon4 = 999;
                }
            }
            else if (sw.pos5 == sannsyou)
            {
                if (GameData.soubi == 5)
                {
                    Debug.Log("îjä¸ÇæÇﬂ");
                }
                else
                {
                    Destroy(sw.pos5);
                    sw.pos5 = null;
                    GameData.inventoryWeapon5 = 999;
                }
            }
            else if (sw.pos6 == sannsyou)
            {
                if (GameData.soubi == 6)
                {
                    Debug.Log("îjä¸ÇæÇﬂ");
                }
                else
                {
                    Destroy(sw.pos6);
                    sw.pos6 = null;
                    GameData.inventoryWeapon6 = 999;
                }
            }
            else if (sw.pos7 == sannsyou)
            {
                if (GameData.soubi == 7)
                {
                    Debug.Log("îjä¸ÇæÇﬂ");
                }
                else
                {
                    Destroy(sw.pos7);
                    sw.pos7 = null;
                    GameData.inventoryWeapon7 = 999;
                }
            }
            else if (sw.pos8 == sannsyou)
            {
                if (GameData.soubi == 8)
                {
                    Debug.Log("îjä¸ÇæÇﬂ");
                }
                else
                {
                    Destroy(sw.pos8);
                    sw.pos8 = null;
                    GameData.inventoryWeapon8 = 999;
                }
            }
            else if (sw.pos9 == sannsyou)
            {
                if (GameData.soubi == 9)
                {
                    Debug.Log("îjä¸ÇæÇﬂ");
                }
                else
                {
                    Destroy(sw.pos9);
                    sw.pos9 = null;
                    GameData.inventoryWeapon9 = 999;
                }
            }
            else if (sw.pos10 == sannsyou)
            {
                if (GameData.soubi == 10)
                {
                    Debug.Log("îjä¸ÇæÇﬂ");
                }
                else
                {
                    Destroy(sw.pos10);
                    sw.pos10 = null;
                    GameData.inventoryWeapon10 = 999;

                }
                //WeaponReload();
            }
        }
        //Debug.Log("inventoryWeapon1 "+GameData.inventoryWeapon1);
        //Debug.Log("inventoryWeapon2 "+GameData.inventoryWeapon2);
        //Debug.Log("inventoryWeapon3 "+GameData.inventoryWeapon3);
        //Debug.Log("inventoryWeapon4 "+GameData.inventoryWeapon4);
        //Debug.Log("inventoryWeapon5 "+GameData.inventoryWeapon5);
        //Debug.Log("inventoryWeapon6 "+GameData.inventoryWeapon6);
        //Debug.Log("inventoryWeapon7 "+GameData.inventoryWeapon7);
        //Debug.Log("inventoryWeapon8 "+GameData.inventoryWeapon8);
        //Debug.Log("inventoryWeapon9 "+GameData.inventoryWeapon9);
        //Debug.Log("inventoryWeapon10 "+GameData.inventoryWeapon10);
    }
}

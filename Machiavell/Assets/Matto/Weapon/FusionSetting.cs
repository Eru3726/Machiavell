using UnityEngine;

public class FusionSetting : MonoBehaviour
{
    public Rarerity rare;
    public DropWeapon dw;
    public weaponsannsyoufusion ws;
    public Vector3 motoposi;
    private Vector3 sozaiposi;
    public GameObject sannsyouscripts;
    private GameObject sannsyou;
    private Vector3 fusionmotoposi;
    private Vector3 fusionsozaiposi;
    public Vector3 fusionposi;
    public GameObject fusionmoto;
    public GameObject fusionsozai;
    public bool moto = false;
    public bool sozai = false;
    private bool fusionobj = false;
    private int pos = 0;
    void Start()
    {
        fusionmotoposi = new Vector3(-7, -2.45f, 0);
        fusionsozaiposi = new Vector3(-2.6f, -2.45f, 0);
        fusionposi = new Vector3(1.8f, -2.45f, 0);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);　　　　　　　　　//マウスのポジションにあるやつを検索
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);　　　//hit2dに検索であたったやつをぶちこむ
            if (hit2d.transform.gameObject == fusionmoto)
            {
                fusionmoto.transform.position = motoposi;
                moto = false;
                fusionobj = false;
            }
            else if (hit2d.transform.gameObject == fusionsozai)
            {
                fusionsozai.transform.position = sozaiposi;
                sozai = false;    
            }
        }
    }
    public void fusionmotoset()
    {
        sannsyou = sannsyouscripts.GetComponent<weaponsannsyoufusion>().sannsyou;
        motoposi = sannsyou.transform.position;
        if (sannsyou.transform.position == fusionsozaiposi||sannsyou.transform.position == fusionposi)
        {
            Debug.Log("だめ");
        }
        else if (GameData.soubi == 1 && sannsyou == dw.pos1)
        {
            Debug.Log("装備している武器はセットできません");
        }
        else if (GameData.soubi == 2 && sannsyou == dw.pos2)
        {
            Debug.Log("装備している武器はセットできません");
        }
        else if (GameData.soubi == 3 && sannsyou == dw.pos3)
        {
            Debug.Log("装備している武器はセットできません");
        }
        else if (GameData.soubi == 4 && sannsyou == dw.pos4)
        {
            Debug.Log("装備している武器はセットできません");
        }
        else if (GameData.soubi == 5 && sannsyou == dw.pos5)
        {
            Debug.Log("装備している武器はセットできません");
        }
        else if (GameData.soubi == 6 && sannsyou == dw.pos6)
        {
            Debug.Log("装備している武器はセットできません");
        }
        else if (GameData.soubi == 7 && sannsyou == dw.pos7)
        {
            Debug.Log("装備している武器はセットできません");
        }
        else if (GameData.soubi == 8 && sannsyou == dw.pos8)
        {
            Debug.Log("装備している武器はセットできません");
        }
        else if (GameData.soubi == 9 && sannsyou == dw.pos9)
        {
            Debug.Log("装備している武器はセットできません");
        }
        else if (GameData.soubi == 10 && sannsyou == dw.pos10)
        {
            Debug.Log("装備している武器はセットできません");
        }
        else
        {
            sannsyou.transform.position = fusionmotoposi;
            fusionmoto = sannsyou;
            moto = true;
            Debug.Log("合成元セット");
        }
    }
    public void fusionsozaiset()
    {
        sannsyou = sannsyouscripts.GetComponent<weaponsannsyoufusion>().sannsyou;
        sozaiposi = sannsyou.transform.position;
        if (sannsyou.transform.position == fusionmotoposi || sannsyou.transform.position == fusionposi)
        {
            Debug.Log("だめ");
        }
        else if (GameData.soubi == 1&&sannsyou == dw.pos1)
        {
            Debug.Log("装備している武器はセットできません");
        }
        else if (GameData.soubi == 2 && sannsyou == dw.pos2)
        {
            Debug.Log("装備している武器はセットできません");
        }
        else if (GameData.soubi == 3 && sannsyou == dw.pos3)
        {
            Debug.Log("装備している武器はセットできません");
        }
        else if (GameData.soubi == 4 && sannsyou == dw.pos4)
        {
            Debug.Log("装備している武器はセットできません");
        }
        else if (GameData.soubi == 5 && sannsyou == dw.pos5)
        {
            Debug.Log("装備している武器はセットできません");
        }
        else if (GameData.soubi == 6 && sannsyou == dw.pos6)
        {
            Debug.Log("装備している武器はセットできません");
        }
        else if (GameData.soubi == 7 && sannsyou == dw.pos7)
        {
            Debug.Log("装備している武器はセットできません");
        }
        else if (GameData.soubi == 8 && sannsyou == dw.pos8)
        {
            Debug.Log("装備している武器はセットできません");
        }
        else if (GameData.soubi == 9 && sannsyou == dw.pos9)
        {
            Debug.Log("装備している武器はセットできません");
        }
        else if (GameData.soubi == 10 && sannsyou == dw.pos10)
        {
            Debug.Log("装備している武器はセットできません");
        }
        else
        {
            sannsyou.transform.position = fusionsozaiposi;
            fusionsozai = sannsyou;
            sozai = true;
            Debug.Log("合成素材セット");
        }
    }
    public void fusionset()
    {
        fusionmoto.transform.position = fusionposi;
    }
    public void fusion()
    {
        if (fusionobj == false)
        { 
            Destroy(fusionsozai);
            if (fusionmoto == dw.pos1)
            {
                pos = 1;
                rare.hyouji1 = true;
            }
            else if (fusionmoto == dw.pos2)
            {
                pos = 2;
                rare.hyouji2 = true;
            }
            else if (fusionmoto == dw.pos3)
            {
                pos = 3;
                rare.hyouji3 = true;
            }
            else if (fusionmoto == dw.pos4)
            {
                pos = 4;
                rare.hyouji4 = true;
            }
            else if (fusionmoto == dw.pos5)
            {
                pos = 5;
                rare.hyouji5 = true;
            }
            else if (fusionmoto == dw.pos6)
            {
                pos = 6;
                rare.hyouji6 = true;
            }
            else if (fusionmoto == dw.pos7)
            {
                pos = 7;
                rare.hyouji7 = true;
            }
            else if (fusionmoto == dw.pos8)
            {
                pos = 8;
                rare.hyouji8 = true;
            }
            else if (fusionmoto == dw.pos9)
            {
                pos = 9;
                rare.hyouji9 = true;
            }
            else if (fusionmoto == dw.pos10)
            {
                pos = 10;
                rare.hyouji10 = true;
            }
            if (fusionmoto.tag == "weapon1")
            {
                if (fusionmoto.layer == 6)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/Axe/Axe2");
                    dw.weaponID = 25;
                }
                else if (fusionmoto.layer == 7)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/Bow/Bow2");
                    dw.weaponID = 28;
                }
                else if (fusionmoto.layer == 8)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/CrossBow/CrossBow2");
                    dw.weaponID = 29;
                }
                else if (fusionmoto.layer == 9)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/Hammer/Hammer2");
                    dw.weaponID = 23;
                }
                else if (fusionmoto.layer == 10)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/LargeAxe/LargeAxe2");
                    dw.weaponID = 22;
                }
                else if (fusionmoto.layer == 11)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/LargeSword/LargeSword2");
                    dw.weaponID = 21;
                }
                else if (fusionmoto.layer == 12)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/Rapier/Rapier2");
                    dw.weaponID = 27;
                }
                else if (fusionmoto.layer == 13)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/Spear/Spear2");
                    dw.weaponID = 26;
                }
                else if (fusionmoto.layer == 14)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/Sword/Sword2");
                    dw.weaponID = 24;
                }
            }
            else if (fusionmoto.tag == "weapon2")
            {
                if (fusionmoto.layer == 6)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/Axe/Axe3");
                    dw.weaponID = 35;
                }
                else if (fusionmoto.layer == 7)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/Bow/Bow3");
                    dw.weaponID = 38;
                }
                else if (fusionmoto.layer == 8)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/CrossBow/CrossBow3");
                    dw.weaponID = 39;
                }
                else if (fusionmoto.layer == 9)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/Hammer/Hammer3");
                    dw.weaponID = 33;
                }
                else if (fusionmoto.layer == 10)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/LargeAxe/LargeAxe3");
                    dw.weaponID = 32;
                }
                else if (fusionmoto.layer == 11)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/LargeSword/LargeSword3");
                    dw.weaponID = 31;
                }
                else if (fusionmoto.layer == 12)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/Rapier/Rapier3");
                    dw.weaponID = 37;
                }
                else if (fusionmoto.layer == 13)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/Spear/Spear3");
                    dw.weaponID = 36;
                }
                else if (fusionmoto.layer == 14)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/Sword/Sword3");
                    dw.weaponID = 34;
                }
            }
            else if (fusionmoto.tag == "weapon3")
            {
                if (fusionmoto.layer == 6)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/Axe/Axe4");
                    dw.weaponID = 45;
                }
                else if (fusionmoto.layer == 7)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/Bow/Bow4");
                    dw.weaponID = 48;
                }
                else if (fusionmoto.layer == 8)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/CrossBow/CrossBow4");
                    dw.weaponID = 49;
                }
                else if (fusionmoto.layer == 9)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/Hammer/Hammer4");
                    dw.weaponID = 43;
                }
                else if (fusionmoto.layer == 10)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/LargeAxe/LargeAxe4");
                    dw.weaponID = 42;
                }
                else if (fusionmoto.layer == 11)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/LargeSword/LargeSword4");
                    dw.weaponID = 41;
                }
                else if (fusionmoto.layer == 12)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/Rapier/Rapier4");
                    dw.weaponID = 47;
                }
                else if (fusionmoto.layer == 13)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/Spear/Spear4");
                    dw.weaponID = 46;
                }
                else if (fusionmoto.layer == 14)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/Sword/Sword4");
                    dw.weaponID = 44;
                }
            }
            else if (fusionmoto.tag == "weapon4")
            {
                if (fusionmoto.layer == 6)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/Axe/Axe5");
                    dw.weaponID = 55;
                }
                else if (fusionmoto.layer == 7)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/Bow/Bow5");
                    dw.weaponID = 58;
                }
                else if (fusionmoto.layer == 8)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/CrossBow/CrossBow5");
                    dw.weaponID = 59;
                }
                else if (fusionmoto.layer == 9)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/Hammer/Hammer5");
                    dw.weaponID = 53;
                }
                else if (fusionmoto.layer == 10)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/LargeAxe/LargeAxe5");
                    dw.weaponID = 52;
                }
                else if (fusionmoto.layer == 11)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/LargeSword/LargeSword5");
                    dw.weaponID = 51;
                }
                else if (fusionmoto.layer == 12)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/Rapier/Rapier5");
                    dw.weaponID = 57;
                }
                else if (fusionmoto.layer == 13)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/Spear/Spear5");
                    dw.weaponID = 56;
                }
                else if (fusionmoto.layer == 14)
                {
                    Destroy(fusionmoto);
                    fusionmoto = Resources.Load<GameObject>("Prefabs/Sword/Sword5");
                    dw.weaponID = 54;
                }
            }
            if (pos == 1)
            {
                fusionmoto = dw.pos1 = Instantiate(fusionmoto, fusionposi, Quaternion.identity);
                GameData.inventoryWeapon[0] = dw.weaponID;
            }
            else if (pos == 2)
            {
                fusionmoto = dw.pos2 = Instantiate(fusionmoto, fusionposi, Quaternion.identity);
                GameData.inventoryWeapon[1] = dw.weaponID;
            }
            else if (pos == 3)
            {
                fusionmoto = dw.pos3 = Instantiate(fusionmoto, fusionposi, Quaternion.identity);
                GameData.inventoryWeapon[2] = dw.weaponID;
            }
            else if (pos == 4)
            {
                fusionmoto = dw.pos4 = Instantiate(fusionmoto, fusionposi, Quaternion.identity);
                GameData.inventoryWeapon[3] = dw.weaponID;
            }
            else if (pos == 5)
            {
                fusionmoto = dw.pos5 = Instantiate(fusionmoto, fusionposi, Quaternion.identity);
                GameData.inventoryWeapon[4] = dw.weaponID;
            }
            else if (pos == 6)
            {
                fusionmoto = dw.pos6 = Instantiate(fusionmoto, fusionposi, Quaternion.identity);
                GameData.inventoryWeapon[5] = dw.weaponID;
            }
            else if (pos == 7)
            {
                fusionmoto = dw.pos7 = Instantiate(fusionmoto, fusionposi, Quaternion.identity);
                GameData.inventoryWeapon[6] = dw.weaponID;
            }
            else if (pos == 8)
            {
                fusionmoto = dw.pos8 = Instantiate(fusionmoto, fusionposi, Quaternion.identity);
                GameData.inventoryWeapon[7] = dw.weaponID;
            }
            else if (pos == 9)
            {
                fusionmoto = dw.pos9 = Instantiate(fusionmoto, fusionposi, Quaternion.identity);
                GameData.inventoryWeapon[8] = dw.weaponID;
            }
            else if (pos == 10)
            {
                fusionmoto = dw.pos10 = Instantiate(fusionmoto, fusionposi, Quaternion.identity);
                GameData.inventoryWeapon[9] = dw.weaponID;
            }
            sozai = false;
            fusionobj = true;
            ws.sannsyou = fusionmoto;
            ws.fusionhyouji();
        }
    }
}

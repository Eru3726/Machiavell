using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buki : MonoBehaviour
{
    public Read readclass;

    public Animator animator;    //アニメーター
    KeyCode rightcode;
    KeyCode leftcode;
    KeyCode jumpcode;
    KeyCode dashcode;
    KeyCode attackcode;
    KeyCode menucode;
    public BossPlayer boss;
    public int count;
    public Playe A;
    public Newplayer B;
    public GameObject player;

    private Rigidbody2D rb2d;
    private int weaponID;
    [SerializeField]
    private DataBase db;
    public GameObject bukisprits;
    public Sprite largesword;
    public Sprite largeaxe;
    public Sprite hammer;
    // Start is called before the first frame update
    void Start()
    {
        readclass.enabled = true;
        if (GameData.first == true)
        {
            bukisprits.GetComponent<SpriteRenderer>().sprite = largesword;
        }
        else if (GameData.first == false)
        {
            if (GameData.soubi == 1)
            {
                Debug.Log(db.weapons[weaponID].weaponType);
                weaponID = GameData.inventoryWeapon1;
                if (db.weapons[weaponID].weaponType == Weapon.Type.LargeSword)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = largesword;
                }
                else if (db.weapons[weaponID].weaponType == Weapon.Type.LargeAxe)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = largeaxe;
                }
                else if (db.weapons[weaponID].weaponType == Weapon.Type.Hammer)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = hammer;
                }
            }
            else if (GameData.soubi == 2)
            {
                weaponID = GameData.inventoryWeapon2;
                if (db.weapons[weaponID].weaponType == Weapon.Type.LargeSword)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = largesword;
                }
                else if (db.weapons[weaponID].weaponType == Weapon.Type.LargeAxe)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = largeaxe;
                }
                else if (db.weapons[weaponID].weaponType == Weapon.Type.Hammer)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = hammer;
                }
            }
            else if (GameData.soubi == 3)
            {
                weaponID = GameData.inventoryWeapon3;
                if (db.weapons[weaponID].weaponType == Weapon.Type.LargeSword)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = largesword;
                }
                else if (db.weapons[weaponID].weaponType == Weapon.Type.LargeAxe)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = largeaxe;
                }
                else if (db.weapons[weaponID].weaponType == Weapon.Type.Hammer)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = hammer;
                }
            }
            else if (GameData.soubi == 4)
            {
                weaponID = GameData.inventoryWeapon4;
                if (db.weapons[weaponID].weaponType == Weapon.Type.LargeSword)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = largesword;
                }
                else if (db.weapons[weaponID].weaponType == Weapon.Type.LargeAxe)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = largeaxe;
                }
                else if (db.weapons[weaponID].weaponType == Weapon.Type.Hammer)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = hammer;
                }
            }
            else if (GameData.soubi == 5)
            {
                weaponID = GameData.inventoryWeapon5;
                if (db.weapons[weaponID].weaponType == Weapon.Type.LargeSword)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = largesword;
                }
                else if (db.weapons[weaponID].weaponType == Weapon.Type.LargeAxe)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = largeaxe;
                }
                else if (db.weapons[weaponID].weaponType == Weapon.Type.Hammer)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = hammer;
                }
            }
            else if (GameData.soubi == 6)
            {
                weaponID = GameData.inventoryWeapon6;
                if (db.weapons[weaponID].weaponType == Weapon.Type.LargeSword)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = largesword;
                }
                else if (db.weapons[weaponID].weaponType == Weapon.Type.LargeAxe)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = largeaxe;
                }
                else if (db.weapons[weaponID].weaponType == Weapon.Type.Hammer)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = hammer;
                }
            }
            else if (GameData.soubi == 7)
            {
                weaponID = GameData.inventoryWeapon7;
                if (db.weapons[weaponID].weaponType == Weapon.Type.LargeSword)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = largesword;
                }
                else if (db.weapons[weaponID].weaponType == Weapon.Type.LargeAxe)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = largeaxe;
                }
                else if (db.weapons[weaponID].weaponType == Weapon.Type.Hammer)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = hammer;
                }
            }
            else if (GameData.soubi == 8)
            {
                weaponID = GameData.inventoryWeapon8;
                if (db.weapons[weaponID].weaponType == Weapon.Type.LargeSword)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = largesword;
                }
                else if (db.weapons[weaponID].weaponType == Weapon.Type.LargeAxe)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = largeaxe;
                }
                else if (db.weapons[weaponID].weaponType == Weapon.Type.Hammer)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = hammer;
                }
            }
            else if (GameData.soubi == 9)
            {
                weaponID = GameData.inventoryWeapon9;
                if (db.weapons[weaponID].weaponType == Weapon.Type.LargeSword)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = largesword;
                }
                else if (db.weapons[weaponID].weaponType == Weapon.Type.LargeAxe)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = largeaxe;
                }
                else if (db.weapons[weaponID].weaponType == Weapon.Type.Hammer)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = hammer;
                }
            }
            else if (GameData.soubi == 10)
            {
                weaponID = GameData.inventoryWeapon10;
                if (db.weapons[weaponID].weaponType == Weapon.Type.LargeSword)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = largesword;
                }
                else if (db.weapons[weaponID].weaponType == Weapon.Type.LargeAxe)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = largeaxe;
                }
                else if (db.weapons[weaponID].weaponType == Weapon.Type.Hammer)
                {
                    bukisprits.GetComponent<SpriteRenderer>().sprite = hammer;
                }
            }

            rb2d = GetComponent<Rigidbody2D>();

            this.animator = GetComponent<Animator>();
            //attackcode = GameData.attackkey;
            //rightcode = GameData.rightkey;
            //leftcode = GameData.leftkey;
            //jumpcode = GameData.jumpkey;
            //dashcode = GameData.dashkey;
            //menucode = GameData.healkey;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float stop;
        //stop = Playe.stop;
        stop = Newplayer.stop;

        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }
        if (!boss.Bossroom)
        {
            return;
        }
        int count2;
        ////count2 = A.jumpcout;
        count2 = B.jumpcout;
        int dameg;
        //dameg = Playe.dameg1;
        dameg = Newplayer.dameg1;
        float speed = 0;
        speed = Newplayer.speed;
        if (Input.GetKeyDown(GameData.attackkey))
        {
            Debug.Log("speed"+speed);
            Debug.Log("count"+count);
            Debug.Log("stop"+stop);
        }
        if (Input.GetKeyDown(GameData.attackkey) && count == 0 && speed == 0)
        {
            Debug.Log("bukihyouji");
            this.animator.ResetTrigger("stop");
            this.animator.SetTrigger("buki");
        }
        if (Input.GetKey(GameData.rightkey) && stop == 0 || dameg == 1 && stop == 0)
        {
            count = 1;
            this.animator.SetTrigger("stop");
        }
        else if (Input.GetKey(GameData.leftkey) && stop == 0 || dameg == 1 && stop == 0)
        {
            count = 1;
            this.animator.SetTrigger("stop");
        }
        else if (Input.GetKey(GameData.jumpkey) && stop == 0 || dameg == 1 && stop == 0)
        {
            this.animator.SetTrigger("stop");
        }
        else if (Input.GetKey(GameData.dashkey) && stop == 0 || dameg == 1 && stop == 0)
        {
            count = 1;
            this.animator.SetTrigger("stop");
        }
        else if (dameg == 1)
        {
            count = 0;
        }
        else
        {
            count = 0;
        }
        //this.animator.SetTrigger("syokika");
    }
}

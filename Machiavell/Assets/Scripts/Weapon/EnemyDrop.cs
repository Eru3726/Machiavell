using UnityEngine;

public class EnemyDrop : MonoBehaviour
{
    public int weaponID;

    [SerializeField]
    private DataBase db;

    void Start()
    {
        int rand = Random.Range(1, 101);
        if (rand <= 11)
        {
            this.gameObject.GetComponent<SpriteRenderer>().color = Color.magenta;
            //レア4
            rand = Random.Range(1, 4);
            if (rand == 1)
            {
                //1…大剣
                weaponID = 41;
            }
            else if (rand == 2)
            {
                //2…大斧
                weaponID = 42;
            }
            else if (rand == 3)
            {
                //3…ハンマー
                weaponID = 43;
            }
        }
        else if (rand <= 31)
        {

            this.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
            //レア3
            rand = Random.Range(1, 4);
            if (rand == 1)
            {
                //1…大剣
                weaponID = 31;
            }
            else if (rand == 2)
            {
                //2…大斧
                weaponID = 32;
            }
            else if (rand == 3)
            {
                //3…ハンマー
                weaponID = 33;
            }
        }
        else if (rand <= 61)
        {

            this.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
            //レア2
            rand = Random.Range(1, 4);
            if (rand == 1)
            {
                //1…大剣
                weaponID = 21;
            }
            else if (rand == 2)
            {
                //2…大斧
                weaponID = 22;
            }
            else if (rand == 3)
            {
                //3…ハンマー
                weaponID = 23;
            }
        }
        else
        {

            this.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
            //レア1
            rand = Random.Range(1, 4);
            if (rand == 1)
            {
                //1…大剣
                weaponID = 11;
            }
            else if (rand == 2)
            {
                //2…大斧
                weaponID = 12;
            }
            else if (rand == 3)
            {
                //3…ハンマー
                weaponID = 13;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "grand")
        {
            gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
        }

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("weaponID" + weaponID);
            if (GameData.inventoryWeapon1 == 999)
            {
                GameData.inventoryWeapon1 = weaponID;
                Destroy(gameObject);
                Debug.Log("インベントリ1番に" + weaponID + "が入った！");
                GameData.weaponRarity1 = db.weapons[weaponID].weaponRarity;
                GameData.weaponHp1 = db.weapons[weaponID].weaponHp;
                GameData.weaponStamina1 = db.weapons[weaponID].weaponStamina;
                GameData.weaponAttack1 = db.weapons[weaponID].weaponAttack;
                GameData.weaponGuard1 = db.weapons[weaponID].weaponGuard;
                GameData.weaponLuck1 = db.weapons[weaponID].weaponLuck;
                GameData.weaponLevel1 = db.weapons[weaponID].weaponLevel;
            }
            else if (GameData.inventoryWeapon2 == 999)
            {
                GameData.inventoryWeapon2 = weaponID;
                Destroy(gameObject);
                Debug.Log("インベントリ2番に" + weaponID + "が入った！");
                GameData.weaponRarity2 = db.weapons[weaponID].weaponRarity;
                GameData.weaponHp2 = db.weapons[weaponID].weaponHp;
                GameData.weaponStamina2 = db.weapons[weaponID].weaponStamina;
                GameData.weaponAttack2 = db.weapons[weaponID].weaponAttack;
                GameData.weaponGuard2 = db.weapons[weaponID].weaponGuard;
                GameData.weaponLuck2 = db.weapons[weaponID].weaponLuck;
                GameData.weaponLevel2 = db.weapons[weaponID].weaponLevel;
            }
            else if (GameData.inventoryWeapon3 == 999)
            {
                GameData.inventoryWeapon3 = weaponID;
                Destroy(gameObject);
                Debug.Log("インベントリ3番に" + weaponID + "が入った！");
                GameData.weaponRarity3 = db.weapons[weaponID].weaponRarity;
                GameData.weaponHp3 = db.weapons[weaponID].weaponHp;
                GameData.weaponStamina3 = db.weapons[weaponID].weaponStamina;
                GameData.weaponAttack3 = db.weapons[weaponID].weaponAttack;
                GameData.weaponGuard3 = db.weapons[weaponID].weaponGuard;
                GameData.weaponLuck3 = db.weapons[weaponID].weaponLuck;
                GameData.weaponLevel3 = db.weapons[weaponID].weaponLevel;
            }
            else if (GameData.inventoryWeapon4 == 999)
            {
                GameData.inventoryWeapon4 = weaponID;
                Destroy(gameObject);
                Debug.Log("インベントリ4番に" + weaponID + "が入った！");
                GameData.weaponRarity4 = db.weapons[weaponID].weaponRarity;
                GameData.weaponHp4 = db.weapons[weaponID].weaponHp;
                GameData.weaponStamina4 = db.weapons[weaponID].weaponStamina;
                GameData.weaponAttack4 = db.weapons[weaponID].weaponAttack;
                GameData.weaponGuard4 = db.weapons[weaponID].weaponGuard;
                GameData.weaponLuck4 = db.weapons[weaponID].weaponLuck;
                GameData.weaponLevel4 = db.weapons[weaponID].weaponLevel;
            }
            else if (GameData.inventoryWeapon5 == 999)
            {
                GameData.inventoryWeapon5 = weaponID;
                Destroy(gameObject);
                Debug.Log("インベントリ5番に" + weaponID + "が入った！");
                GameData.weaponRarity5 = db.weapons[weaponID].weaponRarity;
                GameData.weaponHp5 = db.weapons[weaponID].weaponHp;
                GameData.weaponStamina5 = db.weapons[weaponID].weaponStamina;
                GameData.weaponAttack5 = db.weapons[weaponID].weaponAttack;
                GameData.weaponGuard5 = db.weapons[weaponID].weaponGuard;
                GameData.weaponLuck5 = db.weapons[weaponID].weaponLuck;
                GameData.weaponLevel5 = db.weapons[weaponID].weaponLevel;
            }
            else if (GameData.inventoryWeapon6 == 999)
            {
                GameData.inventoryWeapon6 = weaponID;
                Destroy(gameObject);
                Debug.Log("インベントリ6番に" + weaponID + "が入った！");
                GameData.weaponRarity6 = db.weapons[weaponID].weaponRarity;
                GameData.weaponHp6 = db.weapons[weaponID].weaponHp;
                GameData.weaponStamina6 = db.weapons[weaponID].weaponStamina;
                GameData.weaponAttack6 = db.weapons[weaponID].weaponAttack;
                GameData.weaponGuard6 = db.weapons[weaponID].weaponGuard;
                GameData.weaponLuck6 = db.weapons[weaponID].weaponLuck;
                GameData.weaponLevel6 = db.weapons[weaponID].weaponLevel;
            }
            else if (GameData.inventoryWeapon7 == 999)
            {
                GameData.inventoryWeapon7 = weaponID;
                Destroy(gameObject);
                Debug.Log("インベントリ7番に" + weaponID + "が入った！");
                GameData.weaponRarity7 = db.weapons[weaponID].weaponRarity;
                GameData.weaponHp7 = db.weapons[weaponID].weaponHp;
                GameData.weaponStamina7 = db.weapons[weaponID].weaponStamina;
                GameData.weaponAttack7 = db.weapons[weaponID].weaponAttack;
                GameData.weaponGuard7 = db.weapons[weaponID].weaponGuard;
                GameData.weaponLuck7 = db.weapons[weaponID].weaponLuck;
                GameData.weaponLevel7 = db.weapons[weaponID].weaponLevel;
            }
            else if (GameData.inventoryWeapon8 == 999)
            {
                GameData.inventoryWeapon8 = weaponID;
                Destroy(gameObject);
                Debug.Log("インベントリ8番に" + weaponID + "が入った！");
                GameData.weaponRarity8 = db.weapons[weaponID].weaponRarity;
                GameData.weaponHp8 = db.weapons[weaponID].weaponHp;
                GameData.weaponStamina8 = db.weapons[weaponID].weaponStamina;
                GameData.weaponAttack8 = db.weapons[weaponID].weaponAttack;
                GameData.weaponGuard8 = db.weapons[weaponID].weaponGuard;
                GameData.weaponLuck8 = db.weapons[weaponID].weaponLuck;
                GameData.weaponLevel8 = db.weapons[weaponID].weaponLevel;
            }
            else if (GameData.inventoryWeapon9 == 999)
            {
                GameData.inventoryWeapon9 = weaponID;
                Destroy(gameObject);
                Debug.Log("インベントリ9番に" + weaponID + "が入った！");
                GameData.weaponRarity9 = db.weapons[weaponID].weaponRarity;
                GameData.weaponHp9 = db.weapons[weaponID].weaponHp;
                GameData.weaponStamina9 = db.weapons[weaponID].weaponStamina;
                GameData.weaponAttack9 = db.weapons[weaponID].weaponAttack;
                GameData.weaponGuard9 = db.weapons[weaponID].weaponGuard;
                GameData.weaponLuck9 = db.weapons[weaponID].weaponLuck;
                GameData.weaponLevel9 = db.weapons[weaponID].weaponLevel;
            }
            else if (GameData.inventoryWeapon10 == 999)
            {
                GameData.inventoryWeapon10 = weaponID;
                Destroy(gameObject);
                Debug.Log("インベントリ10番に" + weaponID + "が入った！");
                GameData.weaponRarity10 = db.weapons[weaponID].weaponRarity;
                GameData.weaponHp10 = db.weapons[weaponID].weaponHp;
                GameData.weaponStamina10 = db.weapons[weaponID].weaponStamina;
                GameData.weaponAttack10 = db.weapons[weaponID].weaponAttack;
                GameData.weaponGuard10 = db.weapons[weaponID].weaponGuard;
                GameData.weaponLuck10 = db.weapons[weaponID].weaponLuck;
                GameData.weaponLevel10 = db.weapons[weaponID].weaponLevel;
            }
            else
            {
                Debug.Log("インベントリがいっぱいです");
            }
            Debug.Log(db.weapons[weaponID].weaponName);
            Debug.Log("Weapon1" + GameData.inventoryWeapon1);
            Debug.Log("Weapon2" + GameData.inventoryWeapon2);
            Debug.Log("Weapon3" + GameData.inventoryWeapon3);
            Debug.Log("Weapon4" + GameData.inventoryWeapon4);
            Debug.Log("Weapon5" + GameData.inventoryWeapon5);
            Debug.Log("Weapon6" + GameData.inventoryWeapon6);
            Debug.Log("Weapon7" + GameData.inventoryWeapon7);
            Debug.Log("Weapon8" + GameData.inventoryWeapon8);
            Debug.Log("Weapon9" + GameData.inventoryWeapon9);
            Debug.Log("Weapon10" + GameData.inventoryWeapon10);
        }
    }
}

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
            if (GameData.inventoryWeapon[0] == 999 || GameData.inventoryWeapon[0] == 0)
            {
                GameData.inventoryWeapon[0] = weaponID;
                Destroy(gameObject);
                Debug.Log("インベントリ1番に" + weaponID + "が入った！");
                GameData.weaponRarity[0] = db.weapons[weaponID].weaponRarity;
                GameData.weaponHp[0] = db.weapons[weaponID].weaponHp;
                GameData.weaponStamina[0] = db.weapons[weaponID].weaponStamina;
                GameData.weaponAttack[0] = db.weapons[weaponID].weaponAttack;
                GameData.weaponGuard[0] = db.weapons[weaponID].weaponGuard;
                GameData.weaponLuck[0] = db.weapons[weaponID].weaponLuck;
                GameData.weaponLevel[0] = db.weapons[weaponID].weaponLevel;
            }
            else if (GameData.inventoryWeapon[1] == 999 || GameData.inventoryWeapon[1] == 0)
            {
                GameData.inventoryWeapon[1] = weaponID;
                Destroy(gameObject);
                Debug.Log("インベントリ2番に" + weaponID + "が入った！");
                GameData.weaponRarity[1] = db.weapons[weaponID].weaponRarity;
                GameData.weaponHp[1] = db.weapons[weaponID].weaponHp;
                GameData.weaponStamina[1] = db.weapons[weaponID].weaponStamina;
                GameData.weaponAttack[1] = db.weapons[weaponID].weaponAttack;
                GameData.weaponGuard[1] = db.weapons[weaponID].weaponGuard;
                GameData.weaponLuck[1] = db.weapons[weaponID].weaponLuck;
                GameData.weaponLevel[1] = db.weapons[weaponID].weaponLevel;
            }
            else if (GameData.inventoryWeapon[2] == 999 || GameData.inventoryWeapon[2] == 0)
            {
                GameData.inventoryWeapon[2] = weaponID;
                Destroy(gameObject);
                Debug.Log("インベントリ3番に" + weaponID + "が入った！");
                GameData.weaponRarity[2] = db.weapons[weaponID].weaponRarity;
                GameData.weaponHp[2] = db.weapons[weaponID].weaponHp;
                GameData.weaponStamina[2] = db.weapons[weaponID].weaponStamina;
                GameData.weaponAttack[2] = db.weapons[weaponID].weaponAttack;
                GameData.weaponGuard[2] = db.weapons[weaponID].weaponGuard;
                GameData.weaponLuck[2] = db.weapons[weaponID].weaponLuck;
                GameData.weaponLevel[2] = db.weapons[weaponID].weaponLevel;
            }
            else if (GameData.inventoryWeapon[3] == 999 || GameData.inventoryWeapon[3] == 0)
            {
                GameData.inventoryWeapon[3] = weaponID;
                Destroy(gameObject);
                Debug.Log("インベントリ4番に" + weaponID + "が入った！");
                GameData.weaponRarity[3] = db.weapons[weaponID].weaponRarity;
                GameData.weaponHp[3] = db.weapons[weaponID].weaponHp;
                GameData.weaponStamina[3] = db.weapons[weaponID].weaponStamina;
                GameData.weaponAttack[3] = db.weapons[weaponID].weaponAttack;
                GameData.weaponGuard[3] = db.weapons[weaponID].weaponGuard;
                GameData.weaponLuck[3] = db.weapons[weaponID].weaponLuck;
                GameData.weaponLevel[3] = db.weapons[weaponID].weaponLevel;
            }
            else if (GameData.inventoryWeapon[4] == 999 || GameData.inventoryWeapon[4] == 0)
            {
                GameData.inventoryWeapon[4] = weaponID;
                Destroy(gameObject);
                Debug.Log("インベントリ5番に" + weaponID + "が入った！");
                GameData.weaponRarity[4] = db.weapons[weaponID].weaponRarity;
                GameData.weaponHp[4] = db.weapons[weaponID].weaponHp;
                GameData.weaponStamina[4] = db.weapons[weaponID].weaponStamina;
                GameData.weaponAttack[4] = db.weapons[weaponID].weaponAttack;
                GameData.weaponGuard[4] = db.weapons[weaponID].weaponGuard;
                GameData.weaponLuck[4] = db.weapons[weaponID].weaponLuck;
                GameData.weaponLevel[4] = db.weapons[weaponID].weaponLevel;
            }
            else if (GameData.inventoryWeapon[5] == 999 || GameData.inventoryWeapon[5] == 0)
            {
                GameData.inventoryWeapon[5] = weaponID;
                Destroy(gameObject);
                Debug.Log("インベントリ6番に" + weaponID + "が入った！");
                GameData.weaponRarity[5] = db.weapons[weaponID].weaponRarity;
                GameData.weaponHp[5] = db.weapons[weaponID].weaponHp;
                GameData.weaponStamina[5] = db.weapons[weaponID].weaponStamina;
                GameData.weaponAttack[5] = db.weapons[weaponID].weaponAttack;
                GameData.weaponGuard[5] = db.weapons[weaponID].weaponGuard;
                GameData.weaponLuck[5] = db.weapons[weaponID].weaponLuck;
                GameData.weaponLevel[5] = db.weapons[weaponID].weaponLevel;
            }
            else if (GameData.inventoryWeapon[6] == 999 || GameData.inventoryWeapon[6] == 0)
            {
                GameData.inventoryWeapon[6] = weaponID;
                Destroy(gameObject);
                Debug.Log("インベントリ7番に" + weaponID + "が入った！");
                GameData.weaponRarity[6] = db.weapons[weaponID].weaponRarity;
                GameData.weaponHp[6] = db.weapons[weaponID].weaponHp;
                GameData.weaponStamina[6] = db.weapons[weaponID].weaponStamina;
                GameData.weaponAttack[6] = db.weapons[weaponID].weaponAttack;
                GameData.weaponGuard[6] = db.weapons[weaponID].weaponGuard;
                GameData.weaponLuck[6] = db.weapons[weaponID].weaponLuck;
                GameData.weaponLevel[6] = db.weapons[weaponID].weaponLevel;
            }
            else if (GameData.inventoryWeapon[7] == 999 || GameData.inventoryWeapon[7] == 0)
            {
                GameData.inventoryWeapon[7] = weaponID;
                Destroy(gameObject);
                Debug.Log("インベントリ8番に" + weaponID + "が入った！");
                GameData.weaponRarity[7] = db.weapons[weaponID].weaponRarity;
                GameData.weaponHp[7] = db.weapons[weaponID].weaponHp;
                GameData.weaponStamina[7] = db.weapons[weaponID].weaponStamina;
                GameData.weaponAttack[7] = db.weapons[weaponID].weaponAttack;
                GameData.weaponGuard[7] = db.weapons[weaponID].weaponGuard;
                GameData.weaponLuck[7] = db.weapons[weaponID].weaponLuck;
                GameData.weaponLevel[7] = db.weapons[weaponID].weaponLevel;
            }
            else if (GameData.inventoryWeapon[8] == 999 || GameData.inventoryWeapon[8] == 0)
            {
                GameData.inventoryWeapon[8] = weaponID;
                Destroy(gameObject);
                Debug.Log("インベントリ9番に" + weaponID + "が入った！");
                GameData.weaponRarity[8] = db.weapons[weaponID].weaponRarity;
                GameData.weaponHp[8] = db.weapons[weaponID].weaponHp;
                GameData.weaponStamina[8] = db.weapons[weaponID].weaponStamina;
                GameData.weaponAttack[8] = db.weapons[weaponID].weaponAttack;
                GameData.weaponGuard[8] = db.weapons[weaponID].weaponGuard;
                GameData.weaponLuck[8] = db.weapons[weaponID].weaponLuck;
                GameData.weaponLevel[8] = db.weapons[weaponID].weaponLevel;
            }
            else if (GameData.inventoryWeapon[9] == 999 || GameData.inventoryWeapon[9] == 0)
            {
                GameData.inventoryWeapon[9] = weaponID;
                Destroy(gameObject);
                Debug.Log("インベントリ10番に" + weaponID + "が入った！");
                GameData.weaponRarity[9] = db.weapons[weaponID].weaponRarity;
                GameData.weaponHp[9] = db.weapons[weaponID].weaponHp;
                GameData.weaponStamina[9] = db.weapons[weaponID].weaponStamina;
                GameData.weaponAttack[9] = db.weapons[weaponID].weaponAttack;
                GameData.weaponGuard[9] = db.weapons[weaponID].weaponGuard;
                GameData.weaponLuck[9] = db.weapons[weaponID].weaponLuck;
                GameData.weaponLevel[9] = db.weapons[weaponID].weaponLevel;
            }
            else
            {
                Debug.Log("インベントリがいっぱいです");
            }
            Debug.Log(db.weapons[weaponID].weaponName);
            Debug.Log("Weapon1" + GameData.inventoryWeapon[0]);
            Debug.Log("Weapon2" + GameData.inventoryWeapon[1]);
            Debug.Log("Weapon3" + GameData.inventoryWeapon[2]);
            Debug.Log("Weapon4" + GameData.inventoryWeapon[3]);
            Debug.Log("Weapon5" + GameData.inventoryWeapon[4]);
            Debug.Log("Weapon6" + GameData.inventoryWeapon[5]);
            Debug.Log("Weapon7" + GameData.inventoryWeapon[6]);
            Debug.Log("Weapon8" + GameData.inventoryWeapon[7]);
            Debug.Log("Weapon9" + GameData.inventoryWeapon[8]);
            Debug.Log("Weapon10" + GameData.inventoryWeapon[9]);
        }
    }
}

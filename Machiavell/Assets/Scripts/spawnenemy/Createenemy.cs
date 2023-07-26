using UnityEngine;


public class Createenemy : MonoBehaviour
{
    public float enemynumber;
    public GameObject slime;
    public GameObject Slime;
    public GameObject zombie;
    public GameObject Zombie;
    public GameObject bad;
    public GameObject Bad;
    public GameObject debugbutton;
    public GameObject create;
    public GameObject floor;
    public Exp floor1, floor2, floor3, floor4;
    private float Floor;
    Vector3 slimeposi;
    Vector3 zombieposi;
    Vector3 badposi;
    private int slimecount = 0;
    private int zombiecount = 0;
    private int badcount = 0;
    void Start()
    {
        Floor = 1;
        slimeposi = new Vector3(0, 0, 0);
        zombieposi = new Vector3(5, 0, 0);
        badposi = new Vector3(-5, 0, 0);
    }
    void Update()
    {
        Floor = floor.GetComponent<Floor>().floor;
    }


    public void Instansenemy()
    {
        if (enemynumber == 1)
        {
            if (Floor == 1)
            {
                slime.tag = "floor1";
            }
            else if (Floor == 2)
            {
                slime.tag = "floor2";
            }
            else if (Floor == 3)
            {
                slime.tag = "floor3";
            }
            else if (Floor == 4)
            {
                slime.tag = "floor4";
            }

            if (!Slime)
            {
                slimecount *= 2;
                slimeposi.x -= slimecount;
                Slime = create.GetComponent<Spawnbutton>().slime = Instantiate(slime, slimeposi, Quaternion.identity);
                slimecount = 0;
                Debug.Log("a");
            }
            else
            {
                slimeposi.x += 2;
                Slime = create.GetComponent<Spawnbutton>().slime = Instantiate(slime, slimeposi, Quaternion.identity);
                slimecount += 1;
                Debug.Log("b");
            }
        }
        if (enemynumber == 2)
        {
            if (Floor == 1)
            {
                zombie.tag = "floor1";
            }
            else if (Floor == 2)
            {
                zombie.tag = "floor2";
            }
            else if (Floor == 3)
            {
                zombie.tag = "floor3";
            }
            else if (Floor == 4)
            {
                zombie.tag = "floor4";
            }

            if (!Zombie)
            {
                zombiecount *= 2;
                zombieposi.x -= zombiecount;
                Zombie = create.GetComponent<Spawnbutton>().zombie = Instantiate(zombie, zombieposi, Quaternion.identity);
                zombiecount = 0;
                Debug.Log("a");
            }
            else
            {
                zombieposi.x += 2;
                Zombie = create.GetComponent<Spawnbutton>().zombie = Instantiate(zombie, zombieposi, Quaternion.identity);
                zombiecount += 1;
                Debug.Log("b");
            }
        }
        if (enemynumber == 3)
        {
            if (Floor == 1)
            {
                bad.tag = "floor1";
            }
            else if (Floor == 2)
            {
                bad.tag = "floor2";
            }
            else if (Floor == 3)
            {
                bad.tag = "floor3";
            }
            else if (Floor == 4)
            {
                bad.tag = "floor4";
            }

            if (!Bad)
            {
                badcount *= 2;
                badposi.x -= badcount;
                Bad = create.GetComponent<Spawnbutton>().bad = Instantiate(bad, badposi, Quaternion.identity);
                badcount = 0;
                Debug.Log("a");
            }
            else
            {
                badposi.x += 2;
                Bad = create.GetComponent<Spawnbutton>().bad = Instantiate(bad, badposi, Quaternion.identity);
                badcount += 1;
                Debug.Log("b");
            }
        }
    }
}

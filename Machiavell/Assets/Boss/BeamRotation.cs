using UnityEngine;

public class BeamRotation : MonoBehaviour
{
    [SerializeField, Header("DataBase")]
    private Enemy Archange;
    public float beamDamage;

    public float adRotate = 100;

    private float zRotate = 0;

    float timer = 2;

    int methodNo = 0;

    private BOSS_AI boss;

    private Vector3 beam;

    // Start is called before the first frame update
    void Start()
    {
        beamDamage = Archange.enemyBeamAtk;
        GameObject obj = GameObject.Find("Archange");
        boss = obj.GetComponent<BOSS_AI>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (methodNo)
        {
            case 0:
                timer -= Time.deltaTime;
                if (timer < 0)
                {
                    if (boss.midFlg)
                    {
                        timer = 5;
                    }
                    else if (boss.rightFlg)
                    {
                        zRotate = 45;
                        timer = 3;
                    }
                    else
                    {
                        zRotate = 135;
                        timer = 3;
                    }
                    methodNo++;
                }
                break;
            case 1:
                timer -= Time.deltaTime;
                if (boss.midFlg)
                {
                    if (boss.rightFlg)
                    {
                        zRotate = Mathf.Clamp(zRotate - adRotate * Time.deltaTime, -225, 45);
                        transform.eulerAngles = new Vector3(0, 0, zRotate);
                    }
                    else
                    {
                        zRotate = Mathf.Clamp(zRotate + adRotate * Time.deltaTime, 135, 405);
                        transform.eulerAngles = new Vector3(0, 0, zRotate);
                    }
                }
                else if (boss.rightFlg)
                {
                    zRotate = Mathf.Clamp(zRotate + adRotate * Time.deltaTime, 45, 315);
                    transform.eulerAngles = new Vector3(0, 0, zRotate);
                }
                else
                {
                    zRotate = Mathf.Clamp(zRotate - adRotate * Time.deltaTime, -135, 225); ;
                    transform.eulerAngles = new Vector3(0, 0, zRotate);
                }
                if (timer < 0)
                {
                    boss.beamEnd = true;
                    beam = this.gameObject.transform.localScale;
                    beam.x -= 0.08f;
                    this.gameObject.transform.localScale = beam;
                    if (beam.x < 0)
                    {
                        boss.methodNo++;
                        Destroy(gameObject);
                    }
                }
                break;
        }
    }
}

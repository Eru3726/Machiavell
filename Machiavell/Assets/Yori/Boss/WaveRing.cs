using UnityEngine;

public class WaveRing : MonoBehaviour
{
    [SerializeField, Header("DataBase")]
    private Enemy Archange;
    public float waveDamage;
    // Start is called before the first frame update
    private void Start()
    {
        waveDamage = Archange.enemyWaveAtk;
    }
    // Update is called once per frame
    void Update()
    {
        this.transform.localScale += new Vector3(0.1f, 0.1f, 0);
        if (this.transform.localScale.x >= 60)
        {
            Destroy(gameObject);
        }
    }
}

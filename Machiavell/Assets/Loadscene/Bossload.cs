using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bossload : MonoBehaviour
{
    public GameObject player;
    public Newplayer npl;
    public Save saveClass;

    [SerializeField]
    private Fade fade;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("goal");
        if (collision.gameObject == player)
        {
            fade.FadeIn(1f, () => SceneManager.LoadScene("KutyuBoss"));
            GameData.playerhpnow = (int)npl.hp;
            saveClass.enabled = true;
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class Bossload : MonoBehaviour
{
    public GameObject player;
    public Newplayer npl;
    public Save saveClass;

    [SerializeField]
    private Fade fade;

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

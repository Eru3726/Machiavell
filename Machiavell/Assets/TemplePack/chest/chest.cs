using System.Collections;
using UnityEngine;

public class chest : MonoBehaviour
{
    public GameObject interactui;
    public GameObject interacttext;
    public KeyCode interact;
    public GameObject openedChest;
    public GameObject portion;
    public bool open = false;
    private bool openFlg = false;
    [SerializeField, Header("開ける効果音")]
    private AudioClip openSE;
    [SerializeField, Header("オーディオソース")]
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(interact) && openFlg)
        {
            openFlg = false;
            interactui.SetActive(false);
            interacttext.SetActive(false);
            StartCoroutine(OpenSE());
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !openFlg )
        {
            Debug.Log("入ったよ");
            interactui.SetActive(true);
            interacttext.SetActive(true);
            openFlg = true;
            interact = GameData.interactkey;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && openFlg)
        {
            Debug.Log("出たよ");
            interactui.SetActive(false);
            interacttext.SetActive(false);
            openFlg = false;
        }
    }
    IEnumerator OpenSE()
    {
        GetComponent<Renderer>().enabled = false;
        Instantiate(openedChest, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 0.8f), Quaternion.identity);
        Instantiate(portion, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + 0.8f), Quaternion.identity);
        audioSource.PlayOneShot(openSE);
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
        yield break;
    }
}

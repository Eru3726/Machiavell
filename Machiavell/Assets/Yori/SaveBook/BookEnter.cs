using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BookEnter : MonoBehaviour
{
    public Save saveClass;
    public Read readClass;
    private Animator animator;
    public GameObject text;
    public KeyCode interact;
    public GameObject waku;
    private bool load = false;
    public Playerspawn ps;
    public Playe pl;
    public Newplayer npl; 
    void Start()
    {
        animator = GetComponent<Animator>();
        text.SetActive(false);
        load = false;
        waku.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(interact) && load == true) 
        {
            //GameData.playerhpnow = (int)pl.hp;
            GameData.playerhpnow = (int)npl.hp;
            GameData.save = true;
            saveClass.enabled = true;
            readClass.enabled = true;
            Debug.Log("セーブができました");
            SceneManager.LoadScene("Inbentory");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("入ったよ");
            animator.SetBool("BookOpen", true);
            text.SetActive(true);
            interact = GameData.interactkey;
            Debug.Log(interact);
            load = true;
            waku.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("出たよ");
            animator.SetBool("BookOpen", false);
            text.SetActive(false);
            load = false;
            waku.SetActive(false);
        }
    }
}

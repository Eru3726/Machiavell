using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEstart : MonoBehaviour
{
    public AudioClip click;
    public AudioClip fusion;
    public AudioClip cansel;
    public AudioClip destroy;
    public AudioClip soubi;
    public AudioClip kettei;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Awake()
    {
        //audioSource = GetComponent<AudioSource>();
    }
    public void clickSE()
    {
        Debug.Log("click");
        audioSource.PlayOneShot(click);
    }
    public void fusionSE()
    {
        audioSource.PlayOneShot(fusion);
    }
    public void canselSE()
    {
        audioSource.PlayOneShot(cansel);
    }
    public void destroySE()
    {
        audioSource.PlayOneShot(destroy);
    }
    public void soubiSE()
    {
        audioSource.PlayOneShot(soubi);
    }
    public void ketteiSE()
    {
        audioSource.PlayOneShot(kettei);
    }
}

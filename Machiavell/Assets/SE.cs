using UnityEngine;

public class SE : MonoBehaviour
{
    [SerializeField, Header("Ç®Å[Ç≈Ç°Ç®ÇªÅ[Ç∑")]
    private AudioSource audioSource;
    [SerializeField, Header("PlayerHitSE")]
    private AudioClip hitDamage;
    [SerializeField, Header("PlayerAttackSE")]
    private AudioClip playerAttack;
    [SerializeField, Header("talis&crystalShotSE")]
    private AudioClip talisCrystalShot;
    [SerializeField, Header("talis&crystalHitSE")]
    private AudioClip talisCrystalhit;
    [SerializeField, Header("angelushitSE")]
    private AudioClip angelusHit;
    // Start is called before the first frame update
    //void Start()
    //{
    //    audioSource = GetComponent<AudioSource>();
    //}

    public void playerHitSE()
    {
        audioSource = this.GetComponent<AudioSource>();
        audioSource.PlayOneShot(hitDamage);
        Debug.Log("PlayerHit");
    }
    public void playerAttackSE()
    {
        audioSource = this.GetComponent<AudioSource>();
        audioSource.PlayOneShot(playerAttack);
        Debug.Log(audioSource);
    }
    public void talisCrystalShotSE()
    {
        audioSource = this.GetComponent<AudioSource>();
        Debug.Log(audioSource);
        Debug.Log(talisCrystalShot);
        audioSource.PlayOneShot(talisCrystalShot);
    }
    public void talisCrystalHitSE()
    {
        audioSource = this.GetComponent<AudioSource>();
        audioSource.PlayOneShot(talisCrystalhit);
    }
    public void angelusHitSE()
    {
        audioSource = this.GetComponent<AudioSource>();
        audioSource.PlayOneShot(angelusHit);
    }
}

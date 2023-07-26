using UnityEngine;

public class PartickleDeath : MonoBehaviour
{
    [SerializeField, Header("Á‚¦‚éŠÔ")]
    private float lifetime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}

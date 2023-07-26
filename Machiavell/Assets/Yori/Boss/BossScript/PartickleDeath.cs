using UnityEngine;

public class PartickleDeath : MonoBehaviour
{
    [SerializeField, Header("消える時間")]
    private float lifetime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}

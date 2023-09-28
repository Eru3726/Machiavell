using UnityEngine;
using UnityEngine.SceneManagement;

public class Templeload : MonoBehaviour
{
    [SerializeField]
    private Fade fade;
    private void Start()
    {
        Time.timeScale = 1;
    }
    public void Load()
    {
        fade.FadeIn(1f, () => SceneManager.LoadScene("Temple"));
    }
}

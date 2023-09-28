using UnityEngine;

public class titleinstance : MonoBehaviour
{
    public GameObject pause;
    public GameObject config;
    //public GameObject volume;
    public GameObject titlecanvas;
    public GameObject tutrialcanvas;

    public void configinstance()
    {
        pause.SetActive(false);
        config.SetActive(true);
        //volume.SetActive(false);
        tutrialcanvas.SetActive(false);
    }
    public void volumeinstance()
    {
        pause.SetActive(false);
        //volume.SetActive(true);
        tutrialcanvas.SetActive(false);
    }
    public void escape()
    {
        pause.SetActive(true);
        config.SetActive(false);
        //volume.SetActive(false);
        tutrialcanvas.SetActive(false);
    }
    public void escapetitle()
    {
        titlecanvas.SetActive(true);
        pause.SetActive(false);
        config.SetActive(false);
        //volume.SetActive(false);
        tutrialcanvas.SetActive(false);
    }
}

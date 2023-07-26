using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour
{
	float count;
	[SerializeField]
	//�@�|�[�Y�������ɕ\������UI�̃v���n�u
	private GameObject pauseUIPrefab;
	//�@�|�[�YUI�̃C���X�^���X
	private GameObject pauseUIInstance;

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown("q") && count == 0)
		{
			count = 1;
			this.pauseUIPrefab.SetActive(true);

			if (pauseUIInstance == null)
			{
				pauseUIInstance = GameObject.Instantiate(pauseUIPrefab) as GameObject;
				Time.timeScale = 0f;
			}
		}
		else if (Input.GetKeyDown("q") && count == 1)
        {
			Destroy(pauseUIInstance);
		    Time.timeScale = 1f;

			this.pauseUIPrefab.SetActive(false);
			count = 0;
		}
	}
}
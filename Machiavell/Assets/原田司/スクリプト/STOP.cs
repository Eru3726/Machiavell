using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class STOP : MonoBehaviour
{
	[SerializeField]                   //�@�|�[�Y�������ɕ\������UI�̃v���n�u
	private GameObject pauseUIPrefab;  //�@�|�[�YUI�̃C���X�^���X
	private GameObject pauseUIInstance;
	[SerializeField] GameObject Botan;
	bool isDisp = false;

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.B))
		{
			if (isDisp == false)
			{
				//�Q�[���I�u�W�F�N�g��\�����\��
				Botan.SetActive(true);
				isDisp = true;
			}
			else
			{
				Botan.SetActive(false);
				isDisp = false;
			}
		}
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class STOP : MonoBehaviour
{
	[SerializeField]                   //　ポーズした時に表示するUIのプレハブ
	private GameObject pauseUIPrefab;  //　ポーズUIのインスタンス
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
				//ゲームオブジェクト非表示→表示
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

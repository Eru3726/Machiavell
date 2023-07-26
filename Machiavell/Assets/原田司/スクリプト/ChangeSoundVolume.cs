using UnityEngine;

// "AudioSource"コンポーネントがアタッチされていない場合アタッチ
[RequireComponent(typeof(AudioSource))]
public class ChangeSoundVolume : MonoBehaviour
{
	public static AudioSource audioSource;

    public Read readClass;
    public Save saveClass;

    private void Start()
    {
        float Volume;
        Volume = GameData.sound;

        // "AudioSource"コンポーネントを取得
        audioSource = gameObject.GetComponent<AudioSource>();
		GameData.sound = (float)audioSource.volume;

        audioSource.volume = Volume;
    }


    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.P))
        //{
        //    GameData.sound = (float)audioSource.volume;
        //    saveClass.enabled = true;
        //    readClass.enabled = true;
        //    Debug.Log("セーブができました");
        //}
    }
    /// <summary>
    /// スライドバー値の変更イベント
    /// </summary>
    /// <param name="newSliderValue">スライドバーの値(自動的に引数に値が入る)</param>
    public void SoundSliderOnValueChange(float newSliderValue)
	{
		// 音楽の音量をスライドバーの値に変更
		audioSource.volume = newSliderValue;
        GameData.sound = audioSource.volume;
	}
}
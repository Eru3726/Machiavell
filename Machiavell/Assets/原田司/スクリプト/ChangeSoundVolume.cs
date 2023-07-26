using UnityEngine;

// "AudioSource"�R���|�[�l���g���A�^�b�`����Ă��Ȃ��ꍇ�A�^�b�`
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

        // "AudioSource"�R���|�[�l���g���擾
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
        //    Debug.Log("�Z�[�u���ł��܂���");
        //}
    }
    /// <summary>
    /// �X���C�h�o�[�l�̕ύX�C�x���g
    /// </summary>
    /// <param name="newSliderValue">�X���C�h�o�[�̒l(�����I�Ɉ����ɒl������)</param>
    public void SoundSliderOnValueChange(float newSliderValue)
	{
		// ���y�̉��ʂ��X���C�h�o�[�̒l�ɕύX
		audioSource.volume = newSliderValue;
        GameData.sound = audioSource.volume;
	}
}
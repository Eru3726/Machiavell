using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDrop : MonoBehaviour
{   

    private const int dropRate = 10;        //�h���b�v��
    private int rand;                       //����
    private const int probabilityUp = 1;    //�m���A�b�v��
    private int getRate;                    //����m��

    [SerializeField]    
    private int randRange = 3;                  

    private int enemyType;                  //����̎��ID
                                           //0�c�X�e�b�L
                                           //1�c�匕
                                           //2�c�啀
                                           //3�c�n���}�[
                                           //4�c��
                                           //5�c�蕀
                                           //6�c��
                                           //7�c���C�s�A
                                           //8�c�|
                                           //9�c�N���X�{�E

    //�I�u�W�F�N�g�̐����ʒu
    Vector3 position = new Vector3(-8,4,0);
    Vector3 positionXpurasu = new Vector3(1.1f, 0, 0);
    Vector3 positionYmainasu = new Vector3(0, -2, 0);
    int count = 0;
    //����m���v�Z
    public void ProbabilityCalculation(int type)
    {
        enemyType = type;      //����̎�ޔ���
        getRate = dropRate + PlayerStatus.lucky;     // Y = X + L
        Drop(getRate);
    }

//�h���b�v����
public void Drop(int drop)
    {
        //�����K��
        rand = Random.Range(1, 101);
        Debug.Log(rand);

        //����h���b�v
        if(drop >= rand)
        {
            DropWeapon();
            getRate = dropRate;       //������
            Debug.Log("���킪�h���b�v���܂���\n�h���b�v���������ɖ߂�܂���");
        }
        else
        {
            getRate += probabilityUp;      //�m���A�b�v
            Debug.Log("����̓h���b�v���܂���ł���\n�h���b�v�����㏸���܂���");
        }
    }

    //�h���b�v
    public void DropWeapon()
    {
        rand = Random.Range(1, 101);
        rand -= PlayerStatus.lucky;

        //rand -= DHierarchy.hierarchy * 5;

        if (rand <= 1)
        {
            enemyType = Random.Range(1, 8);
            if (enemyType == 1)
            {
                //1�c�匕
                GameObject prefab = Resources.Load<GameObject>("Prefabs/LargeSword/LargeSword5");
                GameObject Object = Instantiate(prefab,position,Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("�ŗL�匕����肵�܂���");
            }
            else if (enemyType == 2)
            {
                //2�c�啀
                GameObject prefab = Resources.Load<GameObject>("Prefabs/LargeAxe/LargeAxe5");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("�ŗL�啀����肵�܂���");
            }
            else if (enemyType == 3)
            {
                //3�c�n���}�[
                GameObject prefab = Resources.Load<GameObject>("Prefabs/Hammer/Hammer5");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("�ŗL�n���}�[����肵�܂���");
            }
            else if (enemyType == 4)
            {
                //4�c��
                GameObject prefab = Resources.Load<GameObject>("Prefabs/Sword/Sword5");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("�ŗL������肵�܂���");
            }
            else if (enemyType == 5)
            {
                //5�c�蕀
                GameObject prefab = Resources.Load<GameObject>("Prefabs/Axe/Axe5");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("�ŗL�蕀����肵�܂���");
            }
            else if (enemyType == 6)
            {
                //6�c��
                GameObject prefab = Resources.Load<GameObject>("Prefabs/Spear/Spear5");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("�ŗL������肵�܂���");
            }
            else if (enemyType == 7)
            {
                //7�c���C�s�A
                GameObject prefab = Resources.Load<GameObject>("Prefabs/Rapier/Rapier5");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("�ŗL���C�s�A����肵�܂���");
            }
            //else if (enemyType == 8)
            //{
            //    //8�c�|
            //    GameObject prefab = Resources.Load<GameObject>("Prefabs/Bow/Bow5");
            //    GameObject Object = Instantiate(prefab, position, Quaternion.identity);
            //    if (count < 17)
            //    {
            //        count += 1;
            //        position += positionXpurasu;
            //    }
            //    else
            //    {
            //        count = 0;
            //        position += positionYmainasu;
            //        position -= new Vector3(-16, 0, 0);
            //    }
            //    Debug.Log("�ŗL�|����肵�܂���");
            //}
            //else if (enemyType == 9)
            //{
            //    //9�c�N���X�{�E
            //    GameObject prefab = Resources.Load<GameObject>("Prefabs/CrossBow/CrossBow5");
            //    GameObject Object = Instantiate(prefab, position, Quaternion.identity);
            //    if (count < 17)
            //    {
            //        count += 1;
            //        position += positionXpurasu;
            //    }
            //    else
            //    {
            //        count = 0;
            //        position += positionYmainasu;
            //        position -= new Vector3(-16, 0, 0);
            //    }
            //    Debug.Log("�ŗL�N���X�{�E����肵�܂���");
            //}
        }
        else if(rand <= 11)
        {
            //���A4
            rand = Random.Range(1, randRange + 1);
            if (rand == 1)
            {
                //1�c�匕
                GameObject prefab = Resources.Load<GameObject>("Prefabs/LargeSword/LargeSword4");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��4�̑匕����肵�܂���");
            }
            else if (rand == 2)
            {
                //2�c�啀
                GameObject prefab = Resources.Load<GameObject>("Prefabs/LargeAxe/LargeAxe4");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��4�̑啀����肵�܂���");
            }
            else if (rand == 3)
            {
                //3�c�n���}�[
                GameObject prefab = Resources.Load<GameObject>("Prefabs/Hammer/Hammer4");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��4�̃n���}�[����肵�܂���");
            }
            else if (rand == 4)
            {
                //4�c��
                GameObject prefab = Resources.Load<GameObject>("Prefabs/Sword/Sword4");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��4�̌�����肵�܂���");
            }
            else if (rand == 5)
            {
                //5�c�蕀
                GameObject prefab = Resources.Load<GameObject>("Prefabs/Axe/Axe4");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��4�̎蕀����肵�܂���");
            }
            else if (rand == 6)
            {
                //6�c��
                GameObject prefab = Resources.Load<GameObject>("Prefabs/Spear/Spear4");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��4�̑�����肵�܂���");
            }
            else if (rand == 7)
            {
                //7�c���C�s�A
                GameObject prefab = Resources.Load<GameObject>("Prefabs/Rapier/Rapier4");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��4�̃��C�s�A����肵�܂���");
            }
            //else if (rand == 8)
            //{
            //    //8�c�|
            //    GameObject prefab = Resources.Load<GameObject>("Prefabs/Bow/Bow4");
            //    GameObject Object = Instantiate(prefab, position, Quaternion.identity);
            //    if (count < 17)
            //    {
            //        count += 1;
            //        position += positionXpurasu;
            //    }
            //    else
            //    {
            //        count = 0;
            //        position += positionYmainasu;
            //        position -= new Vector3(-16, 0, 0);
            //    }
            //    Debug.Log("��4�̋|����肵�܂���");
            //}
            //else if (rand == 9)
            //{
            //    //9�c�N���X�{�E
            //    GameObject prefab = Resources.Load<GameObject>("Prefabs/CrossBow/CrossBow4");
            //    GameObject Object = Instantiate(prefab, position, Quaternion.identity);
            //    if (count < 17)
            //    {
            //        count += 1;
            //        position += positionXpurasu;
            //    }
            //    else
            //    {
            //        count = 0;
            //        position += positionYmainasu;
            //        position -= new Vector3(-16, 0, 0);
            //    }
            //    Debug.Log("��4�̃N���X�{�E����肵�܂���");
            //}
        }
        else if(rand <= 31)
        {
            //���A3
            rand = Random.Range(1, randRange + 1);
            if (rand == 1)
            {
                //1�c�匕
                GameObject prefab = Resources.Load<GameObject>("Prefabs/LargeSword/LargeSword3");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��3�̑匕����肵�܂���");
            }
            else if (rand == 2)
            {
                //2�c�啀
                GameObject prefab = Resources.Load<GameObject>("Prefabs/LargeAxe/LargeAxe3");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��3�̑啀����肵�܂���");
            }
            else if (rand == 3)
            {
                //3�c�n���}�[
                GameObject prefab = Resources.Load<GameObject>("Prefabs/Hammer/Hammer3");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��3�̃n���}�[����肵�܂���");
            }
            else if (rand == 4)
            {
                //4�c��
                GameObject prefab = Resources.Load<GameObject>("Prefabs/Sword/Sword3");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��3�̌�����肵�܂���");
            }
            else if (rand == 5)
            {
                //5�c�蕀
                GameObject prefab = Resources.Load<GameObject>("Prefabs/Axe/Axe3");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��3�̎蕀����肵�܂���");
            }
            else if (rand == 6)
            {
                //6�c��
                GameObject prefab = Resources.Load<GameObject>("Prefabs/Spear/Spear3");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��3�̑�����肵�܂���");
            }
            else if (rand == 7)
            {
                //7�c���C�s�A
                GameObject prefab = Resources.Load<GameObject>("Prefabs/Rapier/Rapier3");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��3�̃��C�s�A����肵�܂���");
            }
            //else if (rand == 8)
            //{
            //    //8�c�|
            //    GameObject prefab = Resources.Load<GameObject>("Prefabs/Bow/Bow3");
            //    GameObject Object = Instantiate(prefab, position, Quaternion.identity);
            //    if (count < 17)
            //    {
            //        count += 1;
            //        position += positionXpurasu;
            //    }
            //    else
            //    {
            //        count = 0;
            //        position += positionYmainasu;
            //        position -= new Vector3(-16, 0, 0);
            //    }
            //    Debug.Log("��3�̋|����肵�܂���");
            //}
            //else if (rand == 9)
            //{
            //    //9�c�N���X�{�E
            //    GameObject prefab = Resources.Load<GameObject>("Prefabs/CrossBow/CrossBow3");
            //    GameObject Object = Instantiate(prefab, position, Quaternion.identity);
            //    if (count < 17)
            //    {
            //        count += 1;
            //        position += positionXpurasu;
            //    }
            //    else
            //    {
            //        count = 0;
            //        position += positionYmainasu;
            //        position -= new Vector3(-16, 0, 0);
            //    }
            //    Debug.Log("��3�̃N���X�{�E����肵�܂���");
            //}
        }
        else if(rand <= 61)
        {
            //���A2
            rand = Random.Range(1, randRange + 1);
            if (rand == 1)
            {
                //1�c�匕
                GameObject prefab = Resources.Load<GameObject>("Prefabs/LargeSword/LargeSword2");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��2�̑匕����肵�܂���");
            }
            else if (rand == 2)
            {
                //2�c�啀
                GameObject prefab = Resources.Load<GameObject>("Prefabs/LargeAxe/LargeAxe2");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��2�̑啀����肵�܂���");
            }
            else if (rand == 3)
            {
                //3�c�n���}�[
                GameObject prefab = Resources.Load<GameObject>("Prefabs/Hammer/Hammer2");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��2�̃n���}�[����肵�܂���");
            }
            else if (rand == 4)
            {
                //4�c��
                GameObject prefab = Resources.Load<GameObject>("Prefabs/Sword/Sword2");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��2�̌�����肵�܂���");
            }
            else if (rand == 5)
            {
                //5�c�蕀
                GameObject prefab = Resources.Load<GameObject>("Prefabs/Axe/Axe2");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��2�̎蕀����肵�܂���");
            }
            else if (rand == 6)
            {
                //6�c��
                GameObject prefab = Resources.Load<GameObject>("Prefabs/Spear/Spear2");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��2�̑�����肵�܂���");
            }
            else if (rand == 7)
            {
                //7�c���C�s�A
                GameObject prefab = Resources.Load<GameObject>("Prefabs/Rapier/Rapier2");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��2�̃��C�s�A����肵�܂���");
            }
            //else if (rand == 8)
            //{
            //    //8�c�|
            //    GameObject prefab = Resources.Load<GameObject>("Prefabs/Bow/Bow2");
            //    GameObject Object = Instantiate(prefab, position, Quaternion.identity);
            //    if (count < 17)
            //    {
            //        count += 1;
            //        position += positionXpurasu;
            //    }
            //    else
            //    {
            //        count = 0;
            //        position += positionYmainasu;
            //        position -= new Vector3(-16, 0, 0);
            //    }
            //    Debug.Log("��2�̋|����肵�܂���");
            //}
            //else if (rand == 9)
            //{
            //    //9�c�N���X�{�E
            //    GameObject prefab = Resources.Load<GameObject>("Prefabs/CrossBow/CrossBow2");
            //    GameObject Object = Instantiate(prefab, position, Quaternion.identity);
            //    if (count < 17)
            //    {
            //        count += 1;
            //        position += positionXpurasu;
            //    }
            //    else
            //    {
            //        count = 0;
            //        position += positionYmainasu;
            //        position -= new Vector3(-16, 0, 0);
            //    }
            //    Debug.Log("��2�̃N���X�{�E����肵�܂���");
            //}
        }
        else
        {
            //���A1
            rand = Random.Range(1, randRange + 1);
            if (rand == 1)
            {
                //1�c�匕
                GameObject prefab = Resources.Load<GameObject>("Prefabs/LargeSword/LargeSword1");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��1�̑匕����肵�܂���");
            }
            else if (rand == 2)
            {
                //2�c�啀
                GameObject prefab = Resources.Load<GameObject>("Prefabs/LargeAxe/LargeAxe1");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��1�̑啀����肵�܂���");
            }
            else if (rand == 3)
            {
                //3�c�n���}�[
                GameObject prefab = Resources.Load<GameObject>("Prefabs/Hammer/Hammer1");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��1�̃n���}�[����肵�܂���");
            }
            else if (rand == 4)
            {
                //4�c��
                GameObject prefab = Resources.Load<GameObject>("Prefabs/Sword/Sword1");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��1�̌�����肵�܂���");
            }
            else if (rand == 5)
            {
                //5�c�蕀
                GameObject prefab = Resources.Load<GameObject>("Prefabs/Axe/Axe1");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��1�̎蕀����肵�܂���");
            }
            else if (rand == 6)
            {
                //6�c��
                GameObject prefab = Resources.Load<GameObject>("Prefabs/Spear/Spear1");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��1�̑�����肵�܂���");
            }
            else if (rand == 7)
            {
                //7�c���C�s�A
                GameObject prefab = Resources.Load<GameObject>("Prefabs/Rapier/Rapier1");
                GameObject Object = Instantiate(prefab, position, Quaternion.identity);
                if (count < 17)
                {
                    count += 1;
                    position += positionXpurasu;
                }
                else
                {
                    count = 0;
                    position += positionYmainasu;
                    position -= new Vector3(-16, 0, 0);
                }
                Debug.Log("��1�̃��C�s�A����肵�܂���");
            }
            //    else if (rand == 8)
            //    {
            //        //8�c�|
            //        GameObject prefab = Resources.Load<GameObject>("Prefabs/Bow/Bow1");
            //        GameObject Object = Instantiate(prefab, position, Quaternion.identity);
            //        if (count < 17)
            //        {
            //            count += 1;
            //            position += positionXpurasu;
            //        }
            //        else
            //        {
            //            count = 0;
            //            position += positionYmainasu;
            //            position -= new Vector3(-16, 0, 0);
            //        }
            //        Debug.Log("��1�̋|����肵�܂���");
            //    }
            //    else if (rand == 9)
            //    {
            //        //9�c�N���X�{�E
            //        GameObject prefab = Resources.Load<GameObject>("Prefabs/CrossBow/CrossBow1");
            //        GameObject Object = Instantiate(prefab, position, Quaternion.identity);
            //        if (count < 17)
            //        {
            //            count += 1;
            //            position += positionXpurasu;
            //        }
            //        else
            //        {
            //            count = 0;
            //            position += positionYmainasu;
            //            position -= new Vector3(-16, 0, 0);
            //        }
            //        Debug.Log("��1�̃N���X�{�E����肵�܂���");
            //    }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDrop : MonoBehaviour
{   

    private const int dropRate = 10;        //ドロップ率
    private int rand;                       //乱数
    private const int probabilityUp = 1;    //確率アップ数
    private int getRate;                    //入手確率

    [SerializeField]    
    private int randRange = 3;                  

    private int enemyType;                  //武器の種類ID
                                           //0…ステッキ
                                           //1…大剣
                                           //2…大斧
                                           //3…ハンマー
                                           //4…剣
                                           //5…手斧
                                           //6…槍
                                           //7…レイピア
                                           //8…弓
                                           //9…クロスボウ

    //オブジェクトの生成位置
    Vector3 position = new Vector3(-8,4,0);
    Vector3 positionXpurasu = new Vector3(1.1f, 0, 0);
    Vector3 positionYmainasu = new Vector3(0, -2, 0);
    int count = 0;
    //入手確率計算
    public void ProbabilityCalculation(int type)
    {
        enemyType = type;      //武器の種類判定
        getRate = dropRate + PlayerStatus.lucky;     // Y = X + L
        Drop(getRate);
    }

//ドロップ判定
public void Drop(int drop)
    {
        //乱数習得
        rand = Random.Range(1, 101);
        Debug.Log(rand);

        //武器ドロップ
        if(drop >= rand)
        {
            DropWeapon();
            getRate = dropRate;       //初期化
            Debug.Log("武器がドロップしました\nドロップ率が初期に戻りました");
        }
        else
        {
            getRate += probabilityUp;      //確率アップ
            Debug.Log("武器はドロップしませんでした\nドロップ率が上昇しました");
        }
    }

    //ドロップ
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
                //1…大剣
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
                Debug.Log("固有大剣を入手しました");
            }
            else if (enemyType == 2)
            {
                //2…大斧
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
                Debug.Log("固有大斧を入手しました");
            }
            else if (enemyType == 3)
            {
                //3…ハンマー
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
                Debug.Log("固有ハンマーを入手しました");
            }
            else if (enemyType == 4)
            {
                //4…剣
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
                Debug.Log("固有剣を入手しました");
            }
            else if (enemyType == 5)
            {
                //5…手斧
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
                Debug.Log("固有手斧を入手しました");
            }
            else if (enemyType == 6)
            {
                //6…槍
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
                Debug.Log("固有槍を入手しました");
            }
            else if (enemyType == 7)
            {
                //7…レイピア
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
                Debug.Log("固有レイピアを入手しました");
            }
            //else if (enemyType == 8)
            //{
            //    //8…弓
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
            //    Debug.Log("固有弓を入手しました");
            //}
            //else if (enemyType == 9)
            //{
            //    //9…クロスボウ
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
            //    Debug.Log("固有クロスボウを入手しました");
            //}
        }
        else if(rand <= 11)
        {
            //レア4
            rand = Random.Range(1, randRange + 1);
            if (rand == 1)
            {
                //1…大剣
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
                Debug.Log("★4の大剣を入手しました");
            }
            else if (rand == 2)
            {
                //2…大斧
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
                Debug.Log("★4の大斧を入手しました");
            }
            else if (rand == 3)
            {
                //3…ハンマー
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
                Debug.Log("★4のハンマーを入手しました");
            }
            else if (rand == 4)
            {
                //4…剣
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
                Debug.Log("★4の剣を入手しました");
            }
            else if (rand == 5)
            {
                //5…手斧
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
                Debug.Log("★4の手斧を入手しました");
            }
            else if (rand == 6)
            {
                //6…槍
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
                Debug.Log("★4の槍を入手しました");
            }
            else if (rand == 7)
            {
                //7…レイピア
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
                Debug.Log("★4のレイピアを入手しました");
            }
            //else if (rand == 8)
            //{
            //    //8…弓
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
            //    Debug.Log("★4の弓を入手しました");
            //}
            //else if (rand == 9)
            //{
            //    //9…クロスボウ
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
            //    Debug.Log("★4のクロスボウを入手しました");
            //}
        }
        else if(rand <= 31)
        {
            //レア3
            rand = Random.Range(1, randRange + 1);
            if (rand == 1)
            {
                //1…大剣
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
                Debug.Log("★3の大剣を入手しました");
            }
            else if (rand == 2)
            {
                //2…大斧
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
                Debug.Log("★3の大斧を入手しました");
            }
            else if (rand == 3)
            {
                //3…ハンマー
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
                Debug.Log("★3のハンマーを入手しました");
            }
            else if (rand == 4)
            {
                //4…剣
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
                Debug.Log("★3の剣を入手しました");
            }
            else if (rand == 5)
            {
                //5…手斧
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
                Debug.Log("★3の手斧を入手しました");
            }
            else if (rand == 6)
            {
                //6…槍
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
                Debug.Log("★3の槍を入手しました");
            }
            else if (rand == 7)
            {
                //7…レイピア
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
                Debug.Log("★3のレイピアを入手しました");
            }
            //else if (rand == 8)
            //{
            //    //8…弓
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
            //    Debug.Log("★3の弓を入手しました");
            //}
            //else if (rand == 9)
            //{
            //    //9…クロスボウ
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
            //    Debug.Log("★3のクロスボウを入手しました");
            //}
        }
        else if(rand <= 61)
        {
            //レア2
            rand = Random.Range(1, randRange + 1);
            if (rand == 1)
            {
                //1…大剣
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
                Debug.Log("★2の大剣を入手しました");
            }
            else if (rand == 2)
            {
                //2…大斧
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
                Debug.Log("★2の大斧を入手しました");
            }
            else if (rand == 3)
            {
                //3…ハンマー
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
                Debug.Log("★2のハンマーを入手しました");
            }
            else if (rand == 4)
            {
                //4…剣
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
                Debug.Log("★2の剣を入手しました");
            }
            else if (rand == 5)
            {
                //5…手斧
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
                Debug.Log("★2の手斧を入手しました");
            }
            else if (rand == 6)
            {
                //6…槍
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
                Debug.Log("★2の槍を入手しました");
            }
            else if (rand == 7)
            {
                //7…レイピア
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
                Debug.Log("★2のレイピアを入手しました");
            }
            //else if (rand == 8)
            //{
            //    //8…弓
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
            //    Debug.Log("★2の弓を入手しました");
            //}
            //else if (rand == 9)
            //{
            //    //9…クロスボウ
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
            //    Debug.Log("★2のクロスボウを入手しました");
            //}
        }
        else
        {
            //レア1
            rand = Random.Range(1, randRange + 1);
            if (rand == 1)
            {
                //1…大剣
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
                Debug.Log("★1の大剣を入手しました");
            }
            else if (rand == 2)
            {
                //2…大斧
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
                Debug.Log("★1の大斧を入手しました");
            }
            else if (rand == 3)
            {
                //3…ハンマー
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
                Debug.Log("★1のハンマーを入手しました");
            }
            else if (rand == 4)
            {
                //4…剣
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
                Debug.Log("★1の剣を入手しました");
            }
            else if (rand == 5)
            {
                //5…手斧
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
                Debug.Log("★1の手斧を入手しました");
            }
            else if (rand == 6)
            {
                //6…槍
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
                Debug.Log("★1の槍を入手しました");
            }
            else if (rand == 7)
            {
                //7…レイピア
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
                Debug.Log("★1のレイピアを入手しました");
            }
            //    else if (rand == 8)
            //    {
            //        //8…弓
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
            //        Debug.Log("★1の弓を入手しました");
            //    }
            //    else if (rand == 9)
            //    {
            //        //9…クロスボウ
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
            //        Debug.Log("★1のクロスボウを入手しました");
            //    }
        }
    }
}

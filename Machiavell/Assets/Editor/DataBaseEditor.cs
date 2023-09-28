using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class DataBaseEditor : EditorWindow
{
    /// <summary>
    /// エディタの作成
    /// </summary>
    [MenuItem("Editor/DataBase")]
    private static void Create()
    {
        // 生成
        DataBaseEditor window = GetWindow<DataBaseEditor>("データベース");
        // 最小サイズ設定
        window.minSize = new Vector2(240, 240);
    }

    //パス
    private const string ASSET_PATH = "Assets/Resources/DataBase.asset";


    //スクロール
    private Vector2 scrollPos;

    //折り畳み判定
    private bool isOpen;
    private bool enemyOpen;
    private bool itemOpen;
    private bool expopen;
    private bool weaponOpen;

    //DataBase
    private DataBase dataBase;

    /// <summary>
    /// レイアウト
    /// </summary>
    private void OnGUI()
    {
        dataBase = AssetDatabase.LoadAssetAtPath<DataBase>(ASSET_PATH);

        using (var scrollView = new EditorGUILayout.ScrollViewScope(scrollPos, GUILayout.Height(position.size.y)))
        {
            scrollPos = scrollView.scrollPosition;

            Color defaultColor = GUI.backgroundColor;

            using (new GUILayout.VerticalScope(EditorStyles.helpBox))
            {
                using (new GUILayout.HorizontalScope(GUI.skin.box))
                {
                    GUI.backgroundColor = Color.magenta;

                    // 書き込みボタン
                    if (GUILayout.Button("書き込み"))
                    {
                        Export();
                    }

                    GUI.backgroundColor = defaultColor;
                }
            }
            
            //折り畳み
            if (dataBase.enemys != null)
            {
                enemyOpen = EditorGUILayout.BeginFoldoutHeaderGroup(enemyOpen, "Enemys");
                if (enemyOpen)
                {
                    for (int i = 0; i < dataBase.enemys.Count; i++)
                    {
                        using (new GUILayout.VerticalScope(EditorStyles.helpBox))
                        {
                            if (dataBase.enemys[i] != null)
                            {
                                GUI.backgroundColor = Color.gray;
                                using (new GUILayout.HorizontalScope(EditorStyles.toolbar))
                                {
                                    //ラベル
                                    GUILayout.Label(dataBase.enemys[i].enemyName);
                                }
                                GUI.backgroundColor = defaultColor;

                                dataBase.enemys[i].enemyMaxHp = EditorGUILayout.IntField("MaxHp", dataBase.enemys[i].enemyMaxHp);
                                dataBase.enemys[i].enemyOffensivePower = EditorGUILayout.IntField("Offens", dataBase.enemys[i].enemyOffensivePower);
                                dataBase.enemys[i].enemyDefensePower = EditorGUILayout.IntField("Defnse", dataBase.enemys[i].enemyDefensePower);
                                dataBase.enemys[i].enemyMoveSpeed = EditorGUILayout.FloatField("Speed", dataBase.enemys[i].enemyMoveSpeed);
                                dataBase.enemys[i].enemyWaitTime = EditorGUILayout.FloatField("WaitTime", dataBase.enemys[i].enemyWaitTime);
                                dataBase.enemys[i].enemyWalkTime = EditorGUILayout.FloatField("WalkTime", dataBase.enemys[i].enemyWalkTime);
                                dataBase.enemys[i].enemyChaseSpeed = EditorGUILayout.FloatField("ChaseSpeed", dataBase.enemys[i].enemyChaseSpeed);
                                dataBase.enemys[i].enemyRangeToChase = EditorGUILayout.FloatField("RangeToChase", dataBase.enemys[i].enemyRangeToChase);
                                dataBase.enemys[i].enemyWaitAfterHitting = EditorGUILayout.FloatField("WaitAfterHitting", dataBase.enemys[i].enemyWaitAfterHitting);
                                dataBase.enemys[i].enemyKnockBackPower = EditorGUILayout.FloatField("KnockBackPower", dataBase.enemys[i].enemyKnockBackPower);
                                dataBase.enemys[i].enemyExp = EditorGUILayout.IntField("Exp", dataBase.enemys[i].enemyExp);
                                dataBase.enemys[i].enemyBeamAtk = EditorGUILayout.IntField("BeamAtk", dataBase.enemys[i].enemyBeamAtk);
                                dataBase.enemys[i].enemyGodLodAtk = EditorGUILayout.IntField("GodLodAtk", dataBase.enemys[i].enemyGodLodAtk);
                                dataBase.enemys[i].enemyWaveAtk = EditorGUILayout.IntField("WaveAtk", dataBase.enemys[i].enemyWaveAtk);
                            }
                        }
                    }
                }
                EditorGUILayout.EndFoldoutHeaderGroup();
            }
            if (dataBase.items != null)
            {
                itemOpen = EditorGUILayout.BeginFoldoutHeaderGroup(itemOpen, "Items");
                if (itemOpen)
                {
                    for (int i = 0; i < dataBase.items.Count; i++)
                    {
                        using (new GUILayout.VerticalScope(EditorStyles.helpBox))
                        {
                            if (dataBase.items[i] != null)
                            {
                                GUI.backgroundColor = Color.gray;
                                using (new GUILayout.HorizontalScope(EditorStyles.toolbar))
                                {
                                    //ラベル
                                    GUILayout.Label(dataBase.items[i].itemName);
                                }
                                GUI.backgroundColor = defaultColor;

                                dataBase.items[i].itemResilience = EditorGUILayout.IntField("Resilience", dataBase.items[i].itemResilience);
                            }
                        }
                    }
                }
                EditorGUILayout.EndFoldoutHeaderGroup();
            }
            if (dataBase.exp != null)
            {
                expopen = EditorGUILayout.BeginFoldoutHeaderGroup(expopen, "exp");
                if (expopen)
                {
                    using (new GUILayout.VerticalScope(EditorStyles.helpBox))
                    {
                        for (int i = 0; i < dataBase.exp.Count; i++)
                        {
                            if (dataBase.exp[i] != null)
                            {
                                GUI.backgroundColor = Color.gray;
                                using (new GUILayout.HorizontalScope(EditorStyles.toolbar))
                                {
                                    //ラベル
                                    GUILayout.Label(dataBase.exp[i].expName);
                                }
                                GUI.backgroundColor = defaultColor;

                                dataBase.exp[i].getexp = EditorGUILayout.IntField("getexp", dataBase.exp[i].getexp);
                            }
                        }
                    }
                }
                EditorGUILayout.EndFoldoutHeaderGroup();
            }
            if (dataBase.weapons != null)
            {
                weaponOpen = EditorGUILayout.BeginFoldoutHeaderGroup(weaponOpen, "Weapons");
                if (weaponOpen)
                {
                    for (int i = 0; i < dataBase.weapons.Count; i++)
                    {
                        using (new GUILayout.VerticalScope(EditorStyles.helpBox))
                        {
                            if (dataBase.weapons[i] != null)
                            {
                                GUI.backgroundColor = Color.gray;
                                using (new GUILayout.HorizontalScope(EditorStyles.toolbar))
                                {
                                    //ラベル
                                    GUILayout.Label(dataBase.weapons[i].weaponName);
                                }
                                GUI.backgroundColor = defaultColor;

                                dataBase.weapons[i].weaponRarity = EditorGUILayout.IntField("Rarity", dataBase.weapons[i].weaponRarity);
                                dataBase.weapons[i].weaponHp = EditorGUILayout.IntField("Hp", dataBase.weapons[i].weaponHp);
                                dataBase.weapons[i].weaponStamina = EditorGUILayout.IntField("Stamina", dataBase.weapons[i].weaponStamina);
                                dataBase.weapons[i].weaponAttack = EditorGUILayout.IntField("Attack", dataBase.weapons[i].weaponAttack);
                                dataBase.weapons[i].weaponGuard = EditorGUILayout.IntField("Guard", dataBase.weapons[i].weaponGuard);
                                dataBase.weapons[i].weaponLuck = EditorGUILayout.IntField("Luck", dataBase.weapons[i].weaponLuck);
                                dataBase.weapons[i].weaponLevel = EditorGUILayout.IntField("Level", dataBase.weapons[i].weaponLevel);
                            }
                        }
                    }
                    EditorGUILayout.EndFoldoutHeaderGroup();
                }
            }
        }
    }

    private void Export()
    {
        // Enemy更新通知
        for (int i = 0; i < dataBase.enemys.Count; i++)
        {
            EditorUtility.SetDirty(dataBase.enemys[i]);
        }

        // Item更新通知
        for (int i = 0; i < dataBase.items.Count; i++)
        {
            EditorUtility.SetDirty(dataBase.items[i]);
        }

        // Exp更新通知
        for (int i = 0; i < dataBase.exp.Count; i++)
        {
            EditorUtility.SetDirty(dataBase.exp[i]);
        }

        // Weapon更新通知
        for (int i = 0; i < dataBase.weapons.Count; i++)
        {
            EditorUtility.SetDirty(dataBase.weapons[i]);
        }

        // 保存
        AssetDatabase.SaveAssets();

        // エディタを最新の状態にする
        AssetDatabase.Refresh();
    }
}
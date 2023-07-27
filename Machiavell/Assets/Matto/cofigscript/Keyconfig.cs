using UnityEngine;
using System;

public class Keyconfig : MonoBehaviour
{
    public string keyStr;
    public KeyCode codechange;

    public Righttext rtx;
    public Rightkey rk;
    public Lefttext ltx;
    public Leftkey lk;
    public Downkey dwk;
    public Downtext dwtx;
    public Jumptext jtx;
    public Jumpkey jk;
    public Dashtext dtx;
    public Dashkey dk;
    public Attacktext atx;
    public Attackkey ak;
    public Healtext htx;
    public Healkey hk;
    public Interactkey ik;
    public Interacttext itx;

    //キーを変えるとき他のコンフィグも変わらないようにするためのやつ
    public bool right;
    public bool left;
    public bool down;
    public bool jump;
    public bool attack;
    public bool dash;
    public bool heal;
    public bool interact;
    void Start()
    {
        right = false;
        left = false;
        down = false;
        jump = false;
        attack = false;
        dash = false;
        heal = false;
        interact = false;
    }

    
    void Update()
    {
        if (right == true)
        {
            left = false;
            down = false;
            jump = false;
            attack = false;
            dash = false;
            heal = false;
            interact = false;
            keycheck();
        }
        else if (left == true)
        {
            right = false;
            down = false;
            jump = false;
            attack = false;
            dash = false;
            heal = false;
            interact = false;
            keycheck();
        }
        else if (down == true)
        {
            right = false;
            left = false;
            jump = false;
            attack = false;
            dash = false;
            heal = false;
            interact = false;
            keycheck();
        }
        else if (jump == true)
        {
            right = false;
            left = false;
            down = false;
            attack = false;
            dash = false;
            heal = false;
            interact = false;
            keycheck();
        }
        else if (attack == true)
        {
            right = false;
            left = false;
            down = false;
            jump = false;
            dash = false;
            heal = false;
            interact = false;
            keycheck();
        }
        else if (dash == true)
        {
            right = false;
            left = false;
            down = false;
            jump = false;
            attack = false;
            heal = false;
            interact = false;
            keycheck();
        }
        else if (heal == true)
        {
            right = false;
            left = false;
            down = false;
            jump = false;
            attack = false;
            dash = false;
            interact = false;
            keycheck();
        }
        else if (interact == true)
        {
            right = false;
            left = false;
            down = false;
            jump = false;
            attack = false;
            dash = false;
            heal = false;
            keycheck();
        }
    }

    public void keycheck()
    {
        if (Input.anyKeyDown&&!(Input.GetKeyDown(KeyCode.Escape)))
        {
            keyStr = Input.inputString;
            //キーボードの押されたキーを取得
            foreach (KeyCode code in Enum.GetValues(typeof(KeyCode)))
            {
                //取得したキーをcodechangeにぶちこむ
                if (Input.GetKeyDown(code))
                {
                    codechange = code;
                    //if (code == KeyCode.F)
                    //{
                    //    keyStr = "F";
                    //}
                    //else if (code == KeyCode.F1)
                    //{
                    //    keyStr = "F1";
                    //}
                    //else if (code == KeyCode.F2)
                    //{
                    //    keyStr = "F2";
                    //}
                    //else if (code == KeyCode.F3)
                    //{
                    //    keyStr = "F3";
                    //}
                    //else if (code == KeyCode.F4)
                    //{
                    //    keyStr = "F4";
                    //}
                    //else if (code == KeyCode.F5)
                    //{
                    //    keyStr = "F5";
                    //}
                    //else if (code == KeyCode.F6)
                    //{
                    //    keyStr = "F6";
                    //}
                    //else if (code == KeyCode.F7)
                    //{
                    //    keyStr = "F7";
                    //}
                    //else if (code == KeyCode.F8)
                    //{
                    //    keyStr = "F8";
                    //}
                    //else if (code == KeyCode.F9)
                    //{
                    //    keyStr = "F9";
                    //}
                    //else if (code == KeyCode.F10)
                    //{
                    //    keyStr = "F10";
                    //}
                    //else if (code == KeyCode.F11)
                    //{
                    //    keyStr = "F11";
                    //}
                    //else if (code == KeyCode.F12)
                    //{
                    //    keyStr = "F12";
                    //}
                    //else if (code == KeyCode.Mouse0)
                    //{
                    //    keyStr = "Mouse1";
                    //}
                    //else if (code == KeyCode.Mouse1)
                    //{
                    //    keyStr = "Mouse2";
                    //}
                    //else if (code == KeyCode.Mouse2)
                    //{
                    //    keyStr = "Mouse3";
                    //}
                    //else if (code == KeyCode.Mouse3)
                    //{
                    //    keyStr = "Mouse4";
                    //}
                    //else if (code == KeyCode.Mouse4)
                    //{
                    //    keyStr = "Mouse5";
                    //}
                    //else if (code == KeyCode.Mouse5)
                    //{
                    //    keyStr = "Mouse6";
                    //}
                    //else if (code == KeyCode.Mouse6)
                    //{
                    //    keyStr = "Mouse7";
                    //}
                    //else if (code == KeyCode.Tab)
                    //{
                    //    keyStr = "Tab";
                    //}
                    //else if (code == KeyCode.LeftShift)
                    //{
                    //    keyStr = "LShift";
                    //}
                    //else if (code == KeyCode.RightShift)
                    //{
                    //    keyStr = "RShift";
                    //}
                    //else if (code == KeyCode.LeftControl)
                    //{
                    //    keyStr = "LControl";
                    //}
                    //else if (code == KeyCode.RightControl)
                    //{
                    //    keyStr = "RControl";
                    //}
                    //else if (code == KeyCode.Escape)
                    //{
                    //    keyStr = "Escape";
                    //}
                    //else if (code == KeyCode.Return)
                    //{
                    //    keyStr = "Enter";
                    //}
                    //else if (code == KeyCode.Backspace)
                    //{
                    //    keyStr = "back";
                    //}
                    //else if (code == KeyCode.Space)
                    //{
                    //    keyStr = "Space";
                    //}
                    //else if (code == KeyCode.RightArrow)
                    //{
                    //    keyStr = "→";
                    //}
                    //else if (code == KeyCode.LeftArrow)
                    //{
                    //    keyStr = "←";
                    //}
                    //else if (code == KeyCode.UpArrow)
                    //{
                    //    keyStr = "↑";
                    //}
                    //else if (code == KeyCode.DownArrow)
                    //{
                    //    keyStr = "↓";
                    //}
                    if (keyStr != "Escape"||keyStr != "Q")
                    {
                        keyStr = codechange.ToString();
                        if (right == true)
                        {
                            if (!(keyStr == GameData.lefttx || keyStr == GameData.downtx || keyStr == GameData.dashtx || keyStr == GameData.jumptx || keyStr == GameData.attacktx || keyStr == GameData.healtx || keyStr == GameData.interacttx))
                            {
                                rtx.righttextchange();
                                rk.rightkeychange();
                                right = false;
                            }
                            else
                            {
                                Debug.Log("同じキーがあります");
                                right = false;
                            }
                        }
                        else if (left == true)
                        {
                            if (!(keyStr == GameData.righttx || keyStr == GameData.downtx || keyStr == GameData.dashtx || keyStr == GameData.jumptx || keyStr == GameData.attacktx || keyStr == GameData.healtx || keyStr == GameData.interacttx))
                            {
                                ltx.lefttextchange();
                                lk.leftkeychange();
                                left = false;
                            }
                            else
                            {
                                Debug.Log("同じキーがあります");
                                left = false;
                            }
                        }
                        else if (down == true)
                        {
                            if (!(keyStr == GameData.lefttx || keyStr == GameData.righttx || keyStr == GameData.dashtx || keyStr == GameData.jumptx || keyStr == GameData.attacktx || keyStr == GameData.healtx || keyStr == GameData.interacttx))
                            {
                                dwtx.downtextchange();
                                dwk.downkeychange();
                                down = false;
                            }
                            else
                            {
                                Debug.Log("同じキーがあります");
                                down = false;
                            }
                        }
                        else if (jump == true)
                        {
                            if (!(keyStr == GameData.lefttx || keyStr == GameData.downtx || keyStr == GameData.dashtx || keyStr == GameData.righttx || keyStr == GameData.attacktx || keyStr == GameData.healtx || keyStr == GameData.interacttx))
                            {
                                jtx.jumptextchange();
                                jk.jumpkeychange();
                                jump = false;
                            }
                            else
                            {
                                Debug.Log("同じキーがあります");
                                jump = false;
                            }
                        }
                        else if (attack == true)
                        {
                            if (!(keyStr == GameData.lefttx || keyStr == GameData.downtx || keyStr == GameData.dashtx || keyStr == GameData.jumptx || keyStr == GameData.righttx || keyStr == GameData.healtx || keyStr == GameData.interacttx))
                            {
                                atx.attacktextchange();
                                ak.attackkeychange();
                                attack = false;
                            }
                            else
                            {
                                Debug.Log("同じキーがあります");
                                attack = false;
                            }
                        }
                        else if (dash == true)
                        {
                            if (!(keyStr == GameData.lefttx || keyStr == GameData.downtx || keyStr == GameData.righttx || keyStr == GameData.jumptx || keyStr == GameData.attacktx || keyStr == GameData.healtx || keyStr == GameData.interacttx))
                            {
                                dtx.dashtextchange();
                                dk.dashkeychange();
                                dash = false;
                            }
                            else
                            {
                                Debug.Log("同じキーがあります");
                                dash = false;
                            }
                        }
                        else if (heal == true)
                        {
                            if (!(keyStr == GameData.lefttx || keyStr == GameData.downtx || keyStr == GameData.dashtx || keyStr == GameData.jumptx || keyStr == GameData.attacktx || keyStr == GameData.righttx || keyStr == GameData.interacttx))
                            {
                                htx.menutextchange();
                                hk.menukeychange();
                                heal = false;
                            }
                            else
                            {
                                Debug.Log("同じキーがあります");
                                heal = false;
                            }
                        }
                        else if (interact == true)
                        {
                            if (!(keyStr == GameData.lefttx || keyStr == GameData.downtx || keyStr == GameData.dashtx || keyStr == GameData.jumptx || keyStr == GameData.attacktx || keyStr == GameData.healtx || keyStr == GameData.righttx))
                            {
                                itx.interacttextchange();
                                ik.interactkeychange();
                                interact = false;
                            }
                            else
                            {
                                Debug.Log("同じキーがあります");
                                interact = false;
                            }
                        }
                    }
                    else
                    {
                        Debug.Log("そのキーはだめ");
                        interact = false;
                    }
                }
            }
        }
    }
}

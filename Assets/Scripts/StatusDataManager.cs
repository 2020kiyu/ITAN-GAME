using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatusDataManager : MonoBehaviour
{
    // 基本情報
    public TextMeshProUGUI 名前_text_main;
    public TextMeshProUGUI レベル_text_main;
    public TextMeshProUGUI 所持金_text_main;
    public TextMeshProUGUI ランク_text_main;
    public TextMeshProUGUI ロール_text_main;
    public TextMeshProUGUI 称号_text_main;

    public TextMeshProUGUI 名前_text_sub;
    public TextMeshProUGUI レベル_text_sub;
    public TextMeshProUGUI 経験値_text;
    public TextMeshProUGUI NEXT経験値_text;
    public TextMeshProUGUI 所持金_text_sub;
    public TextMeshProUGUI ランク_text_sub;
    public TextMeshProUGUI ロール_text_sub;
    public TextMeshProUGUI 貢献値_text;
    public TextMeshProUGUI NEXT貢献値_text;
    public TextMeshProUGUI 称号_text_sub;

    public string 名前_data;
    public int レベル_data;
    public long 経験値_data;
    public long NEXT経験値_data;
    public int 所持金_data;
    public string ランク_data;
    public string ロール_data;
    public long 貢献値_data;
    public long NEXT貢献値_data;
    public string 称号_data;

    // 戦闘値
    public TextMeshProUGUI HP_text;
    public TextMeshProUGUI MP_text;
    public TextMeshProUGUI 物攻_text;
    public TextMeshProUGUI 物防_text;
    public TextMeshProUGUI 魔攻_text;
    public TextMeshProUGUI 魔防_text;
    public TextMeshProUGUI 命中_text;
    public TextMeshProUGUI 回避_text;
    public TextMeshProUGUI CRT_text;
    public TextMeshProUGUI 速度_text;

    public long HP_data;
    public long MP_data;
    public long 物攻_data;
    public long 物防_data;
    public long 魔攻_data;
    public long 魔防_data;
    public long 命中_data;
    public long 回避_data;
    public long CRT_data;
    public double 速度_data;

    // 能力値
    public TextMeshProUGUI 筋力_text;
    public TextMeshProUGUI 耐久_text;
    public TextMeshProUGUI 器用_text;
    public TextMeshProUGUI 敏捷_text;
    public TextMeshProUGUI 魔力_text;
    public TextMeshProUGUI 魔抗_text;
    public TextMeshProUGUI 技量_text;
    public TextMeshProUGUI 幸運_text;

    public long 筋力_data;
    public long 耐久_data;
    public long 器用_data;
    public long 敏捷_data;
    public long 魔力_data;
    public long 魔抗_data;
    public long 技量_data;
    public long 幸運_data;

    // 熟練度値
    public TextMeshProUGUI 剣_text;
    public TextMeshProUGUI 槍_text;
    public TextMeshProUGUI 斧_text;
    public TextMeshProUGUI 短剣_text;
    public TextMeshProUGUI 長柄_text;
    public TextMeshProUGUI 鈍器_text;
    public TextMeshProUGUI 杖_text;
    public TextMeshProUGUI 格闘_text;
    public TextMeshProUGUI 弓_text;
    public TextMeshProUGUI 銃_text;
    public TextMeshProUGUI 攻魔_text;
    public TextMeshProUGUI 回魔_text;

    public long 剣_data;
    public long 槍_data;
    public long 斧_data;
    public long 短剣_data;
    public long 長柄_data;
    public long 鈍器_data;
    public long 杖_data;
    public long 格闘_data;
    public long 弓_data;
    public long 銃_data;
    public long 攻魔_data;
    public long 回魔_data;

    // スタート
    void Start()
    {
        Data_Set();
        Text_Set();
    }

    void Update()
    {
        Text_Set();
    }

    void Data_Set()
    {
        // 基本情報
        名前_data = "ドド素強死郎";
        レベル_data = 998;
        経験値_data = 7777777777;
        NEXT経験値_data = 9999999999;
        所持金_data = 1000;
        ランク_data = "SS";
        貢献値_data = 6666666666;
        NEXT貢献値_data = 9999999999;
        ロール_data = "家畜☆彡";
        称号_data = "うんちんちんまん";

        // 戦闘値
        HP_data = 9;
        MP_data = 99;
        物攻_data = 999;
        物防_data = 9999;
        魔攻_data = 99999;
        魔防_data = 999999;
        命中_data = 9999999;
        回避_data = 9;
        CRT_data = 99;
        速度_data = 99.99;

        // 能力値
        筋力_data = 8;
        耐久_data = 88;
        器用_data = 888;
        敏捷_data = 8888;
        魔力_data = 88888;
        魔抗_data = 888888;
        技量_data = 8888888;
        幸運_data = 88888888;

        // 熟練度値
        剣_data = 7;
        槍_data = 77;
        斧_data = 777;
        短剣_data = 7777;
        長柄_data = 77777;
        鈍器_data = 777777;
        杖_data = 7777777;
        格闘_data = 77777777;
        弓_data = 7777777;
        銃_data = 77777777;
        攻魔_data = 7777777;
        回魔_data = 77777777;
    }

    void Text_Set()
    {
        // 基本情報
        名前_text_main.text      = 名前_data;
        名前_text_sub.text       = 名前_data;
        レベル_text_main.text    = レベル_data.ToString();
        レベル_text_sub.text     = レベル_data.ToString();
        経験値_text.text         = 経験値_data.ToString("N0");
        NEXT経験値_text.text     = NEXT経験値_data.ToString("N0");
        所持金_text_main.text    = 所持金_data.ToString("N0") + "ham";
        所持金_text_sub.text     = 所持金_data.ToString("N0") + "ham";
        ランク_text_main. text   = ランク_data;
        ランク_text_sub.text     = ランク_data;
        貢献値_text.text         = 貢献値_data.ToString("N0");
        NEXT貢献値_text.text     = NEXT貢献値_data.ToString("N0");
        ロール_text_main.text    = ロール_data;
        ロール_text_sub.text     = ロール_data;
        称号_text_main.text      = 称号_data;
        称号_text_sub.text       = 称号_data;

        // 戦闘値
        HP_text.text   = HP_data.ToString("N0");
        MP_text.text   = MP_data.ToString("N0");
        物攻_text.text = 物攻_data.ToString("N0");
        物防_text.text = 物防_data.ToString("N0");
        魔攻_text.text = 魔攻_data.ToString("N0");
        魔防_text.text = 魔防_data.ToString("N0");
        命中_text.text = 命中_data.ToString("N0");
        回避_text.text = 回避_data.ToString("N0");
        CRT_text.text  = CRT_data.ToString("N0") + " %";
        速度_text.text = 速度_data.ToString("N2") + " / sec";

        // 能力値
        筋力_text.text = 筋力_data.ToString("N0");
        耐久_text.text = 耐久_data.ToString("N0");
        器用_text.text = 器用_data.ToString("N0");
        敏捷_text.text = 敏捷_data.ToString("N0");
        魔力_text.text = 魔力_data.ToString("N0");
        魔抗_text.text = 魔抗_data.ToString("N0");
        技量_text.text = 技量_data.ToString("N0");
        幸運_text.text = 幸運_data.ToString("N0");

        // 熟練度値
        剣_text.text   = 剣_data.ToString("N0");
        槍_text.text   = 槍_data.ToString("N0");
        斧_text.text   = 斧_data.ToString("N0");
        短剣_text.text = 短剣_data.ToString("N0");
        長柄_text.text = 長柄_data.ToString("N0");
        鈍器_text.text = 鈍器_data.ToString("N0");
        杖_text.text   = 杖_data.ToString("N0");
        格闘_text.text = 格闘_data.ToString("N0");
        弓_text.text   = 弓_data.ToString("N0");
        銃_text.text   = 銃_data.ToString("N0");
        攻魔_text.text = 攻魔_data.ToString("N0");
        回魔_text.text = 回魔_data.ToString("N0");
    }
}

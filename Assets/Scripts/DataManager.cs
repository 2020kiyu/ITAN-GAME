using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DataManager : MonoBehaviour
{
    // Status
    public TextMeshProUGUI name_text_main;
    public TextMeshProUGUI level_text_main;
    public TextMeshProUGUI money_text_main;
    public TextMeshProUGUI rank_text_main;
    public TextMeshProUGUI role_text_main;
    public TextMeshProUGUI syougo_text_main;

    public TextMeshProUGUI name_text_sub;
    public TextMeshProUGUI level_text_sub;
    public TextMeshProUGUI ex_text;
    public TextMeshProUGUI ex_emp_text;
    public TextMeshProUGUI money_text_sub;
    public TextMeshProUGUI rank_text_sub;
    public TextMeshProUGUI role_text_sub;
    public TextMeshProUGUI kouken_text;
    public TextMeshProUGUI kouken_emp_text;
    public TextMeshProUGUI syougo_text_sub;

    public string name_data;
    public int level_data;
    public long ex_data;
    public long ex_emp_data;
    public int money_data;
    public string rank_data;
    public string role_data;
    public long kouken_data;
    public long kouken_emp_data;
    public string syougo_data;

    // Setouchi
    public TextMeshProUGUI HP_text;
    public TextMeshProUGUI MP_text;
    public TextMeshProUGUI buturi_text;
    public TextMeshProUGUI butubou_text;
    public TextMeshProUGUI mahou_text;
    public TextMeshProUGUI mabou_text;
    public TextMeshProUGUI meityu_text;
    public TextMeshProUGUI kaihi_text;
    public TextMeshProUGUI CRT_text;
    public TextMeshProUGUI sokudo_text;

    public long HP_data;
    public long MP_data;
    public long buturi_data;
    public long butubou_data;
    public long mahou_data;
    public long mabou_data;
    public long meityu_data;
    public long kaihi_data;
    public long CRT_data;
    public long sokudo_data;

    // Start is called before the first frame update
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
        // Status
        name_data = "ÉhÉhëfã≠éÄòY";
        level_data = 998;
        ex_data = 7777777777;
        ex_emp_data = 9999999999;
        money_data = 1000;
        rank_data = "SS";
        kouken_data = 6666666666;
        kouken_emp_data = 9999999999;
        role_data = "â∆í{Åôúc";
        syougo_data = "Ç§ÇÒÇøÇÒÇøÇÒÇ‹ÇÒ";

        // Setouchi
        HP_data = 9;
        MP_data = 99;
        buturi_data = 999;
        butubou_data = 9999;
        mahou_data = 99999;
        mabou_data = 999999;
        meityu_data = 9999999;
        kaihi_data = 9;
        CRT_data = 99;
        sokudo_data = 999;

    }

    void Text_Set()
    {
        // Status
        name_text_main.text = name_data;
        name_text_sub.text = name_data;
        level_text_main.text = level_data.ToString();
        level_text_sub. text = level_data.ToString();
        ex_text.text = ex_data.ToString("N0");
        ex_emp_text.text = ex_emp_data.ToString("N0");
        money_text_main.text = money_data.ToString("N0") + "ham";
        money_text_sub.text = money_data.ToString("N0") + "ham";
        rank_text_main. text = rank_data;
        rank_text_sub.text = rank_data;
        kouken_text.text = kouken_data.ToString("N0");
        kouken_emp_text.text = kouken_emp_data.ToString("N0");
        role_text_main.text = role_data;
        role_text_sub.text = role_data;
        syougo_text_main.text = syougo_data;
        syougo_text_sub.text= syougo_data;

        // Setouchi
        HP_text.text = HP_data.ToString("N0");
        MP_text.text = MP_data.ToString("N0");
        buturi_text.text = buturi_data.ToString("N0");
        butubou_text.text = butubou_data.ToString("N0");
        mahou_text.text = mahou_data.ToString("N0");
        mabou_text.text = mabou_data.ToString("N0");
        meityu_text.text = meityu_data.ToString("N0");
        kaihi_text.text = kaihi_data.ToString("N0");
        CRT_text.text = CRT_data.ToString("N0");
        sokudo_text.text = sokudo_data.ToString("N0");
    }
}

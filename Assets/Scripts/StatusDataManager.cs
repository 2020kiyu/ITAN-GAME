using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatusDataManager : MonoBehaviour
{
    // Šî–{î•ñ
    public TextMeshProUGUI –¼‘O_text_main;
    public TextMeshProUGUI ƒŒƒxƒ‹_text_main;
    public TextMeshProUGUI Š‹à_text_main;
    public TextMeshProUGUI ƒ‰ƒ“ƒN_text_main;
    public TextMeshProUGUI ƒ[ƒ‹_text_main;
    public TextMeshProUGUI Ì†_text_main;

    public TextMeshProUGUI –¼‘O_text_sub;
    public TextMeshProUGUI ƒŒƒxƒ‹_text_sub;
    public TextMeshProUGUI ŒoŒ±’l_text;
    public TextMeshProUGUI NEXTŒoŒ±’l_text;
    public TextMeshProUGUI Š‹à_text_sub;
    public TextMeshProUGUI ƒ‰ƒ“ƒN_text_sub;
    public TextMeshProUGUI ƒ[ƒ‹_text_sub;
    public TextMeshProUGUI vŒ£’l_text;
    public TextMeshProUGUI NEXTvŒ£’l_text;
    public TextMeshProUGUI Ì†_text_sub;

    public string –¼‘O_data;
    public int ƒŒƒxƒ‹_data;
    public long ŒoŒ±’l_data;
    public long NEXTŒoŒ±’l_data;
    public int Š‹à_data;
    public string ƒ‰ƒ“ƒN_data;
    public string ƒ[ƒ‹_data;
    public long vŒ£’l_data;
    public long NEXTvŒ£’l_data;
    public string Ì†_data;

    // í“¬’l
    public TextMeshProUGUI HP_text;
    public TextMeshProUGUI MP_text;
    public TextMeshProUGUI •¨U_text;
    public TextMeshProUGUI •¨–h_text;
    public TextMeshProUGUI –‚U_text;
    public TextMeshProUGUI –‚–h_text;
    public TextMeshProUGUI –½’†_text;
    public TextMeshProUGUI ‰ñ”ğ_text;
    public TextMeshProUGUI CRT_text;
    public TextMeshProUGUI ‘¬“x_text;

    public long HP_data;
    public long MP_data;
    public long •¨U_data;
    public long •¨–h_data;
    public long –‚U_data;
    public long –‚–h_data;
    public long –½’†_data;
    public long ‰ñ”ğ_data;
    public long CRT_data;
    public double ‘¬“x_data;

    // ”\—Í’l
    public TextMeshProUGUI ‹Ø—Í_text;
    public TextMeshProUGUI ‘Ï‹v_text;
    public TextMeshProUGUI Ší—p_text;
    public TextMeshProUGUI •q·_text;
    public TextMeshProUGUI –‚—Í_text;
    public TextMeshProUGUI –‚R_text;
    public TextMeshProUGUI ‹Z—Ê_text;
    public TextMeshProUGUI K‰^_text;

    public long ‹Ø—Í_data;
    public long ‘Ï‹v_data;
    public long Ší—p_data;
    public long •q·_data;
    public long –‚—Í_data;
    public long –‚R_data;
    public long ‹Z—Ê_data;
    public long K‰^_data;

    // n—û“x’l
    public TextMeshProUGUI Œ•_text;
    public TextMeshProUGUI ‘„_text;
    public TextMeshProUGUI •€_text;
    public TextMeshProUGUI ’ZŒ•_text;
    public TextMeshProUGUI ’·•¿_text;
    public TextMeshProUGUI “İŠí_text;
    public TextMeshProUGUI ñ_text;
    public TextMeshProUGUI Ši“¬_text;
    public TextMeshProUGUI ‹|_text;
    public TextMeshProUGUI e_text;
    public TextMeshProUGUI U–‚_text;
    public TextMeshProUGUI ‰ñ–‚_text;

    public long Œ•_data;
    public long ‘„_data;
    public long •€_data;
    public long ’ZŒ•_data;
    public long ’·•¿_data;
    public long “İŠí_data;
    public long ñ_data;
    public long Ši“¬_data;
    public long ‹|_data;
    public long e_data;
    public long U–‚_data;
    public long ‰ñ–‚_data;

    // ƒXƒ^[ƒg
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
        // Šî–{î•ñ
        –¼‘O_data = "ƒhƒh‘f‹­€˜Y";
        ƒŒƒxƒ‹_data = 998;
        ŒoŒ±’l_data = 7777777777;
        NEXTŒoŒ±’l_data = 9999999999;
        Š‹à_data = 1000;
        ƒ‰ƒ“ƒN_data = "SS";
        vŒ£’l_data = 6666666666;
        NEXTvŒ£’l_data = 9999999999;
        ƒ[ƒ‹_data = "‰Æ’{™œc";
        Ì†_data = "‚¤‚ñ‚¿‚ñ‚¿‚ñ‚Ü‚ñ";

        // í“¬’l
        HP_data = 9;
        MP_data = 99;
        •¨U_data = 999;
        •¨–h_data = 9999;
        –‚U_data = 99999;
        –‚–h_data = 999999;
        –½’†_data = 9999999;
        ‰ñ”ğ_data = 9;
        CRT_data = 99;
        ‘¬“x_data = 99.99;

        // ”\—Í’l
        ‹Ø—Í_data = 8;
        ‘Ï‹v_data = 88;
        Ší—p_data = 888;
        •q·_data = 8888;
        –‚—Í_data = 88888;
        –‚R_data = 888888;
        ‹Z—Ê_data = 8888888;
        K‰^_data = 88888888;

        // n—û“x’l
        Œ•_data = 7;
        ‘„_data = 77;
        •€_data = 777;
        ’ZŒ•_data = 7777;
        ’·•¿_data = 77777;
        “İŠí_data = 777777;
        ñ_data = 7777777;
        Ši“¬_data = 77777777;
        ‹|_data = 7777777;
        e_data = 77777777;
        U–‚_data = 7777777;
        ‰ñ–‚_data = 77777777;
    }

    void Text_Set()
    {
        // Šî–{î•ñ
        –¼‘O_text_main.text      = –¼‘O_data;
        –¼‘O_text_sub.text       = –¼‘O_data;
        ƒŒƒxƒ‹_text_main.text    = ƒŒƒxƒ‹_data.ToString();
        ƒŒƒxƒ‹_text_sub.text     = ƒŒƒxƒ‹_data.ToString();
        ŒoŒ±’l_text.text         = ŒoŒ±’l_data.ToString("N0");
        NEXTŒoŒ±’l_text.text     = NEXTŒoŒ±’l_data.ToString("N0");
        Š‹à_text_main.text    = Š‹à_data.ToString("N0") + "ham";
        Š‹à_text_sub.text     = Š‹à_data.ToString("N0") + "ham";
        ƒ‰ƒ“ƒN_text_main. text   = ƒ‰ƒ“ƒN_data;
        ƒ‰ƒ“ƒN_text_sub.text     = ƒ‰ƒ“ƒN_data;
        vŒ£’l_text.text         = vŒ£’l_data.ToString("N0");
        NEXTvŒ£’l_text.text     = NEXTvŒ£’l_data.ToString("N0");
        ƒ[ƒ‹_text_main.text    = ƒ[ƒ‹_data;
        ƒ[ƒ‹_text_sub.text     = ƒ[ƒ‹_data;
        Ì†_text_main.text      = Ì†_data;
        Ì†_text_sub.text       = Ì†_data;

        // í“¬’l
        HP_text.text   = HP_data.ToString("N0");
        MP_text.text   = MP_data.ToString("N0");
        •¨U_text.text = •¨U_data.ToString("N0");
        •¨–h_text.text = •¨–h_data.ToString("N0");
        –‚U_text.text = –‚U_data.ToString("N0");
        –‚–h_text.text = –‚–h_data.ToString("N0");
        –½’†_text.text = –½’†_data.ToString("N0");
        ‰ñ”ğ_text.text = ‰ñ”ğ_data.ToString("N0");
        CRT_text.text  = CRT_data.ToString("N0") + " %";
        ‘¬“x_text.text = ‘¬“x_data.ToString("N2") + " / sec";

        // ”\—Í’l
        ‹Ø—Í_text.text = ‹Ø—Í_data.ToString("N0");
        ‘Ï‹v_text.text = ‘Ï‹v_data.ToString("N0");
        Ší—p_text.text = Ší—p_data.ToString("N0");
        •q·_text.text = •q·_data.ToString("N0");
        –‚—Í_text.text = –‚—Í_data.ToString("N0");
        –‚R_text.text = –‚R_data.ToString("N0");
        ‹Z—Ê_text.text = ‹Z—Ê_data.ToString("N0");
        K‰^_text.text = K‰^_data.ToString("N0");

        // n—û“x’l
        Œ•_text.text   = Œ•_data.ToString("N0");
        ‘„_text.text   = ‘„_data.ToString("N0");
        •€_text.text   = •€_data.ToString("N0");
        ’ZŒ•_text.text = ’ZŒ•_data.ToString("N0");
        ’·•¿_text.text = ’·•¿_data.ToString("N0");
        “İŠí_text.text = “İŠí_data.ToString("N0");
        ñ_text.text   = ñ_data.ToString("N0");
        Ši“¬_text.text = Ši“¬_data.ToString("N0");
        ‹|_text.text   = ‹|_data.ToString("N0");
        e_text.text   = e_data.ToString("N0");
        U–‚_text.text = U–‚_data.ToString("N0");
        ‰ñ–‚_text.text = ‰ñ–‚_data.ToString("N0");
    }
}

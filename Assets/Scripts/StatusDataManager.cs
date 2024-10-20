using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatusDataManager : MonoBehaviour
{
    // ��{���
    public TextMeshProUGUI ���O_text_main;
    public TextMeshProUGUI ���x��_text_main;
    public TextMeshProUGUI ������_text_main;
    public TextMeshProUGUI �����N_text_main;
    public TextMeshProUGUI ���[��_text_main;
    public TextMeshProUGUI �̍�_text_main;

    public TextMeshProUGUI ���O_text_sub;
    public TextMeshProUGUI ���x��_text_sub;
    public TextMeshProUGUI �o���l_text;
    public TextMeshProUGUI NEXT�o���l_text;
    public TextMeshProUGUI ������_text_sub;
    public TextMeshProUGUI �����N_text_sub;
    public TextMeshProUGUI ���[��_text_sub;
    public TextMeshProUGUI �v���l_text;
    public TextMeshProUGUI NEXT�v���l_text;
    public TextMeshProUGUI �̍�_text_sub;

    public string ���O_data;
    public int ���x��_data;
    public long �o���l_data;
    public long NEXT�o���l_data;
    public int ������_data;
    public string �����N_data;
    public string ���[��_data;
    public long �v���l_data;
    public long NEXT�v���l_data;
    public string �̍�_data;

    // �퓬�l
    public TextMeshProUGUI HP_text;
    public TextMeshProUGUI MP_text;
    public TextMeshProUGUI ���U_text;
    public TextMeshProUGUI ���h_text;
    public TextMeshProUGUI ���U_text;
    public TextMeshProUGUI ���h_text;
    public TextMeshProUGUI ����_text;
    public TextMeshProUGUI ���_text;
    public TextMeshProUGUI CRT_text;
    public TextMeshProUGUI ���x_text;

    public long HP_data;
    public long MP_data;
    public long ���U_data;
    public long ���h_data;
    public long ���U_data;
    public long ���h_data;
    public long ����_data;
    public long ���_data;
    public long CRT_data;
    public double ���x_data;

    // �\�͒l
    public TextMeshProUGUI �ؗ�_text;
    public TextMeshProUGUI �ϋv_text;
    public TextMeshProUGUI ��p_text;
    public TextMeshProUGUI �q��_text;
    public TextMeshProUGUI ����_text;
    public TextMeshProUGUI ���R_text;
    public TextMeshProUGUI �Z��_text;
    public TextMeshProUGUI �K�^_text;

    public long �ؗ�_data;
    public long �ϋv_data;
    public long ��p_data;
    public long �q��_data;
    public long ����_data;
    public long ���R_data;
    public long �Z��_data;
    public long �K�^_data;

    // �n���x�l
    public TextMeshProUGUI ��_text;
    public TextMeshProUGUI ��_text;
    public TextMeshProUGUI ��_text;
    public TextMeshProUGUI �Z��_text;
    public TextMeshProUGUI ����_text;
    public TextMeshProUGUI �݊�_text;
    public TextMeshProUGUI ��_text;
    public TextMeshProUGUI �i��_text;
    public TextMeshProUGUI �|_text;
    public TextMeshProUGUI �e_text;
    public TextMeshProUGUI �U��_text;
    public TextMeshProUGUI ��_text;

    public long ��_data;
    public long ��_data;
    public long ��_data;
    public long �Z��_data;
    public long ����_data;
    public long �݊�_data;
    public long ��_data;
    public long �i��_data;
    public long �|_data;
    public long �e_data;
    public long �U��_data;
    public long ��_data;

    // �X�^�[�g
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
        // ��{���
        ���O_data = "�h�h�f�����Y";
        ���x��_data = 998;
        �o���l_data = 7777777777;
        NEXT�o���l_data = 9999999999;
        ������_data = 1000;
        �����N_data = "SS";
        �v���l_data = 6666666666;
        NEXT�v���l_data = 9999999999;
        ���[��_data = "�ƒ{���c";
        �̍�_data = "���񂿂񂿂�܂�";

        // �퓬�l
        HP_data = 9;
        MP_data = 99;
        ���U_data = 999;
        ���h_data = 9999;
        ���U_data = 99999;
        ���h_data = 999999;
        ����_data = 9999999;
        ���_data = 9;
        CRT_data = 99;
        ���x_data = 99.99;

        // �\�͒l
        �ؗ�_data = 8;
        �ϋv_data = 88;
        ��p_data = 888;
        �q��_data = 8888;
        ����_data = 88888;
        ���R_data = 888888;
        �Z��_data = 8888888;
        �K�^_data = 88888888;

        // �n���x�l
        ��_data = 7;
        ��_data = 77;
        ��_data = 777;
        �Z��_data = 7777;
        ����_data = 77777;
        �݊�_data = 777777;
        ��_data = 7777777;
        �i��_data = 77777777;
        �|_data = 7777777;
        �e_data = 77777777;
        �U��_data = 7777777;
        ��_data = 77777777;
    }

    void Text_Set()
    {
        // ��{���
        ���O_text_main.text      = ���O_data;
        ���O_text_sub.text       = ���O_data;
        ���x��_text_main.text    = ���x��_data.ToString();
        ���x��_text_sub.text     = ���x��_data.ToString();
        �o���l_text.text         = �o���l_data.ToString("N0");
        NEXT�o���l_text.text     = NEXT�o���l_data.ToString("N0");
        ������_text_main.text    = ������_data.ToString("N0") + "ham";
        ������_text_sub.text     = ������_data.ToString("N0") + "ham";
        �����N_text_main. text   = �����N_data;
        �����N_text_sub.text     = �����N_data;
        �v���l_text.text         = �v���l_data.ToString("N0");
        NEXT�v���l_text.text     = NEXT�v���l_data.ToString("N0");
        ���[��_text_main.text    = ���[��_data;
        ���[��_text_sub.text     = ���[��_data;
        �̍�_text_main.text      = �̍�_data;
        �̍�_text_sub.text       = �̍�_data;

        // �퓬�l
        HP_text.text   = HP_data.ToString("N0");
        MP_text.text   = MP_data.ToString("N0");
        ���U_text.text = ���U_data.ToString("N0");
        ���h_text.text = ���h_data.ToString("N0");
        ���U_text.text = ���U_data.ToString("N0");
        ���h_text.text = ���h_data.ToString("N0");
        ����_text.text = ����_data.ToString("N0");
        ���_text.text = ���_data.ToString("N0");
        CRT_text.text  = CRT_data.ToString("N0") + " %";
        ���x_text.text = ���x_data.ToString("N2") + " / sec";

        // �\�͒l
        �ؗ�_text.text = �ؗ�_data.ToString("N0");
        �ϋv_text.text = �ϋv_data.ToString("N0");
        ��p_text.text = ��p_data.ToString("N0");
        �q��_text.text = �q��_data.ToString("N0");
        ����_text.text = ����_data.ToString("N0");
        ���R_text.text = ���R_data.ToString("N0");
        �Z��_text.text = �Z��_data.ToString("N0");
        �K�^_text.text = �K�^_data.ToString("N0");

        // �n���x�l
        ��_text.text   = ��_data.ToString("N0");
        ��_text.text   = ��_data.ToString("N0");
        ��_text.text   = ��_data.ToString("N0");
        �Z��_text.text = �Z��_data.ToString("N0");
        ����_text.text = ����_data.ToString("N0");
        �݊�_text.text = �݊�_data.ToString("N0");
        ��_text.text   = ��_data.ToString("N0");
        �i��_text.text = �i��_data.ToString("N0");
        �|_text.text   = �|_data.ToString("N0");
        �e_text.text   = �e_data.ToString("N0");
        �U��_text.text = �U��_data.ToString("N0");
        ��_text.text = ��_data.ToString("N0");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainTextController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _mainTextObject;

    // Start is called before the first frame update
    void Start()
    {
        // �ŏ��̍s�̃e�L�X�g��\���A�܂��͖��߂����s
        string statement = GameManager.Instance.userScriptManager.GetCurrentSentence();
        if (GameManager.Instance.userScriptManager.IsStatement(statement))
        {
            GameManager.Instance.userScriptManager.ExecuteStatement(statement);
            GoToTheNextLine();
        }
        DisplayText();
    }

    // Update is called once per frame
    void Update()
    {
        // �N���b�N���ꂽ�Ƃ��A���̍s�ֈړ�
        if (Input.GetMouseButtonUp(0))
        {
            GoToTheNextLine();
            DisplayText();
        }
    }

    // ���̍s�ֈړ�
    public void GoToTheNextLine()
    {
        GameManager.Instance.lineNumber++;
        string sentence = GameManager.Instance.userScriptManager.GetCurrentSentence();
        if (GameManager.Instance.userScriptManager.IsStatement(sentence))
        {
            GameManager.Instance.userScriptManager.ExecuteStatement(sentence);
            GoToTheNextLine();
        }
    }

    // �e�L�X�g��\��
    public void DisplayText()
    {
        string sentence = GameManager.Instance.userScriptManager.GetCurrentSentence();
        _mainTextObject.text = sentence;
    }
}

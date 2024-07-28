using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusController : MonoBehaviour
{
    public Button status_Button;
    public Button soubi_Button;
    public Button sukiru_Button;
    public Button syojihin_Button;
    public Button option_Button;
    public Button status_X_Button;
    public Button soubi_X_Button;
    public Button sukiru_X_Button;
    public Button syojihin_X_Button;
    public Button option_X_Button;
    public GameObject status_Object;
    public GameObject soubi_Object;
    public GameObject sukiru_Object;
    public GameObject syojihin_Object;
    public GameObject option_Object;

    // Start is called before the first frame update
    void Start()
    {
        status_Button.onClick.AddListener(Status_ButtonClick);
        soubi_Button.onClick.AddListener(Soubi_ButtonClick);
        sukiru_Button.onClick.AddListener(Sukiru_ButtonClick);
        syojihin_Button.onClick.AddListener(Syojihin_ButtonClick);
        option_Button.onClick.AddListener(Option_ButtonClick);
        status_X_Button.onClick.AddListener(Status_X_ButtonClick);
        soubi_X_Button.onClick.AddListener(Soubi_X_ButtonClick);
        sukiru_X_Button.onClick.AddListener(Sukiru_X_ButtonClick);
        syojihin_X_Button.onClick.AddListener(Syojihin_X_ButtonClick);
        option_X_Button.onClick.AddListener(Option_X_ButtonClick);
        AllDeActive();

    }
    void AllDeActive()
    {
        status_Object.SetActive(false);
        soubi_Object.SetActive(false);
        sukiru_Object.SetActive(false);
        syojihin_Object.SetActive(false);
        option_Object.SetActive(false);
    }
    void Status_ButtonClick()
    {
        AllDeActive();
        status_Object.SetActive(true);
    }
    void Soubi_ButtonClick()
    {
        AllDeActive();
        soubi_Object.SetActive(true);
    }
    void Sukiru_ButtonClick()
    {
        AllDeActive();
        sukiru_Object.SetActive(true);
    }
    void Syojihin_ButtonClick()
    {
        AllDeActive();
        syojihin_Object.SetActive(true);
    }
    void Option_ButtonClick()
    {
        AllDeActive();
        option_Object.SetActive(true);
    }
    void Status_X_ButtonClick()
    {
        AllDeActive();
    }
    void Soubi_X_ButtonClick()
    {
        AllDeActive();
    }
    void Sukiru_X_ButtonClick()
    {
        AllDeActive();
    }
    void Syojihin_X_ButtonClick()
    {
        AllDeActive();
    }
    void Option_X_ButtonClick()
    {
        AllDeActive();
    }
}

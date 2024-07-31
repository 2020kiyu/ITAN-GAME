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
    public Button X_Button;
    public GameObject popup_Object;
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
        X_Button.onClick.AddListener(X_ButtonClick);
        AllDeActive();

    }
    void AllDeActive()
    {
        popup_Object.SetActive(false);
        status_Object.SetActive(false);
        soubi_Object.SetActive(false);
        sukiru_Object.SetActive(false);
        syojihin_Object.SetActive(false);
        option_Object.SetActive(false);
    }
    public void Status_ButtonClick()
    {
        AllDeActive();
        popup_Object.SetActive(true);
        status_Object.SetActive(true);
    }
    public void Soubi_ButtonClick()
    {
        AllDeActive();
        popup_Object.SetActive(true);
        soubi_Object.SetActive(true);
    }
    public void Sukiru_ButtonClick()
    {
        AllDeActive();
        popup_Object.SetActive(true);
        sukiru_Object.SetActive(true);
    }
    public void Syojihin_ButtonClick()
    {
        AllDeActive();
        popup_Object.SetActive(true);
        syojihin_Object.SetActive(true);
    }
    public void Option_ButtonClick()
    {
        AllDeActive();
        popup_Object.SetActive(true);
        option_Object.SetActive(true);
    }
    public void X_ButtonClick()
    {
        AllDeActive();
    }
}

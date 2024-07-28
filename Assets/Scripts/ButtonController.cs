using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Button syokyuButton;
    public Button tyukyuButton;
    public Button jyokyuButton;
    public Button shimeiButton;
    public GameObject syokyuObject;
    public GameObject tyukyuObject;
    public GameObject jyokyuObject;
    public GameObject shimeiObject;

    // Start is called before the first frame update
    void Start()
    {
        syokyuButton.onClick.AddListener(SyokyuButtonClick);
        tyukyuButton.onClick.AddListener(TyuKyuButtonClick);
        jyokyuButton.onClick.AddListener(JyokyuButtonClick);
        shimeiButton.onClick.AddListener(ShimeiButtonClick);
        syokyuObject.SetActive(true);
        tyukyuObject.SetActive(false);
        jyokyuObject.SetActive(false);
        shimeiObject.SetActive(false);

    }

    void SyokyuButtonClick()
    {
        syokyuObject.SetActive(true);
        tyukyuObject.SetActive(false);
        jyokyuObject.SetActive(false);
        shimeiObject.SetActive(false);
    }

    void TyuKyuButtonClick()
    {
        syokyuObject.SetActive(false);
        tyukyuObject.SetActive(true);
        jyokyuObject.SetActive(false);
        shimeiObject.SetActive(false);
    }

    void JyokyuButtonClick()
    {
        syokyuObject.SetActive(false);
        tyukyuObject.SetActive(false);
        jyokyuObject.SetActive(true);
        shimeiObject.SetActive(false);
    }

    void ShimeiButtonClick()
    {
        syokyuObject.SetActive(false);
        tyukyuObject.SetActive(false);
        jyokyuObject.SetActive(false);
        shimeiObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

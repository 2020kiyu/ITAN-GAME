using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Button syokyuButton;
    public Button tyukyuButton;
    public GameObject syokyuObject;
    public GameObject tyukyuObject;

    // Start is called before the first frame update
    void Start()
    {
        syokyuButton.onClick.AddListener(SyokyuButtonClick);
        tyukyuButton.onClick.AddListener(TyuKyuButtonClick);
        syokyuObject.SetActive(true);
        tyukyuObject.SetActive(false);

    }

    void SyokyuButtonClick()
    {
        syokyuObject.SetActive(true);
        tyukyuObject.SetActive(false);
    }

    void TyuKyuButtonClick()
    {
        syokyuObject.SetActive(false);
        tyukyuObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

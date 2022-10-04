using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NumberButton : MonoBehaviour
{
    public Numbers Number;
    public Button Button;
    public TextMeshProUGUI Text;

    public event Action<int> ButtonClicked;

    void Awake()
    {
        Button.onClick.AddListener(OnButtonClicked);
        Text.text = ((int)Number).ToString();
    }

    private void OnButtonClicked()
    {
        if (ButtonClicked != null)
            ButtonClicked.Invoke((int)Number);
        for(int i = 0; i < 10; i++)
        {
            if (Input.GetKey(Convert.ToString(i)))
            {
                ButtonClicked.Invoke(i);
            }
        }
    }
}
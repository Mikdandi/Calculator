using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;
using UnityEngine.UI;

public class NumberButtoms : MonoBehaviour
{
    public Numbers Number;
    public Button Button;
    public Text Text;

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

    }
}
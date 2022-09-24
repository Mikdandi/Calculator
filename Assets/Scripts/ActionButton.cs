

using System;
using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;
using UnityEngine.UI;

public class ActionButton : MonoBehaviour
{
    public ActionType Action;
    public Button Button;
    public Text Text;
    private Dictionary<ActionType, string> ActionName = new Dictionary<ActionType, string>()
    {
        {
            ActionType.Add,"+"
        },
        {
            ActionType.Dillenna,"/"
        },
        {
            ActionType.Minus,"-"
        },
        {
            ActionType.Mult,"*"
        },
        {
            ActionType.Result,"="
        }
    };
    public event Action<ActionType, string> ButtonClicked;

    void Awake()
    {
        Button.onClick.AddListener(OnButtonClicked);
        Text.text = ActionName[Action];
    }

    private void OnButtonClicked()
    {
        if (ButtonClicked != null)
            ButtonClicked.Invoke(Action, ActionName[Action]);

    }
}


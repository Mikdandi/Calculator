using System;
using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static Assets.Scripts.ActionType;
public class ActionButton : MonoBehaviour
{
    public ActionType Action;
    public Button Button;
    public TextMeshProUGUI Text;
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
        },
        {
            ActionType.ChangeSign,"+/-"
        },
        {
            ActionType.ToZero,"AC"
        },
        {
            ActionType.Persentage,"%"
        },
        {
            ActionType.Dot,"."
        }
    };
    public event Action<ActionType, string> ButtonClicked;

    void Awake()
    {
        Button.onClick.AddListener(OnButtonClicked);
        Text.text = ActionName[Action];
        Debug.Log("Awake ActionButton" + ActionName[Action]);
    }

    private void OnButtonClicked()
    {
        if (ButtonClicked != null)
            ButtonClicked.Invoke(Action, ActionName[Action]);
        if (Input.GetKey("*"))
        {
            ButtonClicked.Invoke(Action, ActionName[Action]);
        }
        if (Input.GetKey("+"))
        {
            ButtonClicked.Invoke(Action, ActionName[Action]);
        }
        if (Input.GetKey("-"))
        {
            ButtonClicked.Invoke(Action, ActionName[Action]);
        }
        if (Input.GetKey("."))
        {
            ButtonClicked.Invoke(Action, ActionName[Action]);
        }
        if (Input.GetKey("/"))
        {
            ButtonClicked.Invoke(Action, ActionName[Action]);
        }
        if (Input.GetKey("a"))
        {
            ButtonClicked.Invoke(Action, ActionName[Action]);
        }
        if (Input.GetKey("%"))
        {
            ButtonClicked.Invoke(Action, ActionName[Action]);
        }
    }
}


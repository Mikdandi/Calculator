using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Assets.Scripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static Assets.Scripts.ActionType;
namespace Assets.Scripts
{
    public class KeyboardActionButton
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
        public event Action<ActionType, string> KeyboardButtonClicked;

        void Awake()
        {
            Button.onClick.AddListener(KeyboardOnButtonClicked);
            Text.text = ActionName[Action];
            Debug.Log("Awake  KeyboardActionButton");
        }

        private void KeyboardOnButtonClicked()
        {

            if (Input.GetKey("*"))
            {
                KeyboardButtonClicked.Invoke(Action, ActionName[Action]);
            }
            if (Input.GetKey("+"))
            {
                KeyboardButtonClicked.Invoke(Action, ActionName[Action]);
            }
            if (Input.GetKey("-"))
            {
                KeyboardButtonClicked.Invoke(Action, ActionName[Action]);
            }
            if (Input.GetKey("."))
            {
                KeyboardButtonClicked.Invoke(Action, ActionName[Action]);
            }
            if (Input.GetKey("/"))
            {
                KeyboardButtonClicked.Invoke(Action, ActionName[Action]);
            }
            if (Input.GetKey("a"))
            {
                KeyboardButtonClicked.Invoke(Action, ActionName[Action]);
            }
            if (Input.GetKey("%"))
            {
                KeyboardButtonClicked.Invoke(Action, ActionName[Action]);
            }
        /*    private IEnumerator waitForKeyPress(KeyCode key)
            {
                bool done = false;
                while (!done) 
                    if (Input.GetKeyDown(key))
                    {
                        done = true; 
                    yield return null; 

                // now this function returns
            }*/
        }
    }
}

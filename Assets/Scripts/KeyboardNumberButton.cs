using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Scripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class KeyboardNumberButton
    {
        public Numbers Number;
        public Button Button;
        public TextMeshProUGUI Text;

        public event Action<int> KeyboardButtonClicked;
        void Awake()
        {
            Button.onClick.AddListener(KeyboardOnButtonClicked);
            Text.text = ((int)Number).ToString();
        }
        private void KeyboardOnButtonClicked()
        {
            for (int i = 0; i < 10; i++)
            {
                if (Input.GetKey(Convert.ToString(i)))
                {
                    KeyboardButtonClicked.Invoke(i);
                }
            }
        }
    }
}

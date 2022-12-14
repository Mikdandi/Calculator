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
    public class KeyboardNumberButton:MonoBehaviour
    {
        public Numbers Number;
        public Button Button;
        public TextMeshProUGUI Text;

        public event Action<int> KeyboardButtonClicked;
        private void Update()
        {
            for (int i = 0; i < 10; i++)
            {
                if (Input.GetKeyDown(Convert.ToString(i)))
                {
                    KeyboardButtonClicked.Invoke(i);
                    Debug.Log("Awake keybord " + i);

                }
            }
        }

    }
}

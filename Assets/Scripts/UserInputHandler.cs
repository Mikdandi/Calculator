using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class UserInputHandler: MonoBehaviour
    {
        public event Action<int> KeyboardButtonClicked;
        private void Update()
        {
            for (int i = 0; i < 10; i++)
            {
                if (Input.GetKeyDown(Convert.ToString(i)))
                {
                    KeyboardButtonClicked.Invoke(i);
                }
            }
        }
    }
}

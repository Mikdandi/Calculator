using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;
using System;

namespace Assets.Scripts
{
    public class CalculatorDisplay : MonoBehaviour
    {
        public TextMeshProUGUI ResultDisplay;

        public void Display(double result)
        {
            ResultDisplay.text = result.ToString();
        }
        public void DisplayAction(string action)
        {
            ResultDisplay.text = action;
        }
    }
}
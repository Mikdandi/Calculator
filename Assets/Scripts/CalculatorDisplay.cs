using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;

public class CalculatorDisplay : MonoBehaviour
{
    public TextMeshProUGUI ResultDisplay;

    public void Display(double result)
    {
        ResultDisplay.text = result.ToString();
    }
}
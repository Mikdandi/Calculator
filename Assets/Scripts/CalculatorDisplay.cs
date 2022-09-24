using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;

public class CalculatorDisplay : MonoBehaviour
{
    public Text ResultDisplay;

    public void Display(int result)
    {
        ResultDisplay.text = result.ToString();
    }
}
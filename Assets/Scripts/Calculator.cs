using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Calculator : MonoBehaviour
{

    public TextMeshProUGUI inputText;

    private double _result;
    private double _input1;
    private double _input2;
    private string _operation;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void ClickNumber(int val)
    {
        Debug.Log("val: " + val);
        inputText.text=$"{val}";
        if (_input1 == 0)
        {
            _input1 = val;
        }
        else
        {
            _input2 = val;
        }


    }

    public void ClickOperation(string val)
    {
        Debug.Log("val: " + val);
        _operation = val;

    }

    public void ClickResult(string val)
    {
        Debug.Log("val: " + val);
        if(_input1!=0 && _input2!=0 && !string.IsNullOrEmpty(_operation))
        {
            switch (_operation)
            {
                case "+":
                    {
                        _result = _input1 + _input2;
                        break;
                    }
                case "-":
                    {
                        _result = _input1 - _input2;
                        break;
                    }
                case "*":
                    {
                        _result = _input1 * _input2;
                        break;
                    }
                case "/":
                    {
                        _result = _input1 / _input2;
                        break;
                    }

            }
        }
        inputText.SetText(_result.ToString());
        ClearInput();
    }

    private void ClearInput()
    {
        _input1 = 0;
        _input2 = 0;
    }

    public void ClickPeriod(string val)
    {
        Debug.Log("val: " + val);
        //  result = val;
    }
}

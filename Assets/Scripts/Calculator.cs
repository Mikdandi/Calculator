using UnityEngine;

namespace Assets.Scripts
{
    public class Calculator : MonoBehaviour
    {
        public CalculatorDisplay Display;
        public NumberButton[] NumberButtons;
        public ActionButton[] ActionButtons;
        private double _lastResult;
        private ActionType _actionType = ActionType.NotSelected;
        private double _numberOne=0;
        private double _numberTwo = 0;
        private int _stepdot1 = 1;
        private int _stepdot2 = 1;

        void Start()
        {
            foreach (var button in NumberButtons)
            {
                button.ButtonClicked += HandleNumberButtonClick;
            }

            foreach (var actionButton in ActionButtons)
            {
                actionButton.ButtonClicked += OnActionButtonClicked;
            }

        }

        private void OnActionButtonClicked(ActionType actionType, string actionString)
        {
            if (actionType == ActionType.Result)
            {
                CalculateResult();
                ShowResult();
                _numberOne = 0;
                _numberTwo = 0;
                _stepdot1 = 1;
                _stepdot2 = 1;
                _actionType = actionType;
            }
            else
            {
                _actionType = actionType;
                Display.DisplayAction(HandleAction(_actionType));
            }
 

        }

        private void CalculateResult()
        {
            if (_actionType == ActionType.Add)
            {
                _lastResult = _numberOne + _numberTwo;
            }

            else if (_actionType == ActionType.Minus)
            {
                _lastResult = _numberOne - _numberTwo;
            }
            else if (_actionType == ActionType.Mult)
            {
                _lastResult = _numberOne * _numberTwo;
            }
            else if (_actionType == ActionType.Dillenna)
            {
                _lastResult = _numberOne / _numberTwo;
            }
            else if (_actionType == ActionType.ToZero)
            {
                _lastResult = 0;
                _actionType = ActionType.NotSelected;
                _numberOne = 0;
                _numberTwo = 0;
                _stepdot1 = 1;
                _stepdot2 = 1;
            }
            else if (_actionType == ActionType.Persentage)
            {
                _lastResult = _numberOne / _numberTwo*100;
            }
         /*   else if (_actionType == ActionType.ChangeSign)
            {
                _lastResult = _numberOne / _numberTwo;
            }*/
        }

        private void ShowResult()
        {
            Display.Display(_lastResult);
        }

        private void HandleNumberButtonClick(int number)
        {
            Display.Display(number);
            _lastResult = number;
            if (_actionType == ActionType.NotSelected)
            {

                _numberOne = _numberOne*10+number;
                Display.Display(_numberOne);
            }
            else if(_actionType == ActionType.Dot)
            {
                _numberOne = _numberOne + number/(Mathf.Pow(10,_stepdot1));
                _stepdot1++;
            }
            else
            {
                _numberTwo = _numberTwo*10+number;
                Display.Display(_numberTwo);
                if (_actionType == ActionType.Dot)
                {
                    _numberTwo = _numberTwo + number / (Mathf.Pow(10, _stepdot2));
                    _stepdot2++;
                }
            }

        }
        private string HandleAction(ActionType action)
        {
            string result = " ";
            if(action == ActionType.Add)
            {
                result = "+";
            }
            else if (action == ActionType.Dillenna)
            {
                result = "/";
            }
            else if (action == ActionType.Minus)
            {
                result = "-";
            }
            else if (action == ActionType.Mult)
            {
                result = "*";
            }
            else if (action == ActionType.Persentage)
            {
                result = "%";
            }
            return result;
        }


    }
}
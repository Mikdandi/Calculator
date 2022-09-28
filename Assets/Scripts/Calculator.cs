using UnityEngine;

namespace Assets.Scripts
{
    public class Calculator : MonoBehaviour
    {
        public CalculatorDisplay Display;
        public NumberButton[] NumberButtons;
        public ActionButton[] ActionButtons;
        private int _lastResult;
        private ActionType _actionType = ActionType.NotSelected;
        private int _numberOne=0;
        private int _numberTwo=0;

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
            }

            _actionType = actionType;
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
            }
            else
            {
                _numberTwo = _numberTwo*10+number;
            }

        }


    }
}
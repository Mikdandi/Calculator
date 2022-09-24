using UnityEngine;

namespace Assets.Scripts
{
    public class Calculator : MonoBehaviour
    {
        public CalculatorDisplay Display;
        public NumberButtoms[] NumberButtons;
        public ActionButton[] ActionButtons;
        private int _lastResult;
        private ActionType _actionType = ActionType.NotSelected;
        private int _numberOne;
        private int _numberTwo;

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
                _numberOne = number;
            }
            else
            {
                _numberTwo = number;
            }

        }


    }
}
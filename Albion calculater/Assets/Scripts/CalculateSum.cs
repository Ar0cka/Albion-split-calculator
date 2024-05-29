using System.Collections.Generic;
using System.Net.Mime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class CalculateSum : MonoBehaviour
    {
        [SerializeField] private List<TMP_InputField> _inputFields = new List<TMP_InputField>(6);
        [SerializeField] private TextMeshProUGUI _sumText;
        [SerializeField] private TextMeshProUGUI _splitText;
        [SerializeField] private AddNewInputField _addNewInputField;

        private List<int> quantityInputFields;
        private List<Toggle> _toggles;
        
        public void Calculate()
        {
            int sum = 0;
            
            foreach (var inputField in _inputFields)
            {
                if (inputField.text != "")
                sum += int.Parse(inputField.text);
            }

            _sumText.text = sum.ToString();
            SplitLoot(sum);
            
            sum = 0;
        }

        private void SplitLoot(int sum)
        {
            if (quantityInputFields == null) 
                quantityInputFields = _addNewInputField.QuantityInputFields();
            
            if (_toggles == null) 
                _toggles = _addNewInputField.Toggles();

            int split = 0;

            for (int i = 0; i < _toggles.Count; i++)
            {
                if (_toggles[i].isOn)
                {
                    split = quantityInputFields[i];
                }
            }

            if (split > 0) 
                sum /= split;

            _splitText.text = sum.ToString();
        }

        public void ClearSumTexts()
        {
            _sumText.text = "";
            _splitText.text = "";

            foreach (var inputField in _inputFields)
            {
                inputField.text = "";
            }
        }
    }
}
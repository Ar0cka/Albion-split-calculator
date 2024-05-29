using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class ValidationInput : MonoBehaviour
    { 
        private TMP_InputField inputField;

        private void Awake()
        {
            if (inputField == null)
            {
                inputField = GetComponent<TMP_InputField>();
            }

            // Ограничение на ввод только целых чисел
            inputField.contentType = TMP_InputField.ContentType.IntegerNumber;

            // Дополнительная проверка на изменение текста
            inputField.onValueChanged.AddListener(ValidateInput);
        }

        private void ValidateInput(string input)
        {
            // Убедимся, что введенные данные являются целым числом
            int result;
            if (!int.TryParse(input, out result) && input != "")
            {
                // Удаляем последний введенный символ, если он не является цифрой
                inputField.text = inputField.text.Remove(inputField.text.Length - 1);
                inputField.caretPosition = inputField.text.Length;
            }
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Toggle = UnityEngine.UI.Toggle;

public class AddNewInputField : MonoBehaviour
{
    [SerializeField] private List<GameObject> _inputFields = new List<GameObject>(5);

    [SerializeField] private List<Toggle> _toggles = new List<Toggle>(5);
    
    [SerializeField] private List<int> _quantityInputFields = new List<int>(5);

    private void Awake()
    {
        AddNewInputFieldInDependenceToggle();
    }

    public void AddNewInputFieldInDependenceToggle()
    {
        for (int i = 0; i < _toggles.Count; i++)
        {
            if (_toggles[i].isOn)
            {
                SearchInputField(_quantityInputFields[i]);
            }
        }
    }

    private void SearchInputField(int quantityInputFields)
    {
        foreach (var inputField in _inputFields)
        {
            inputField.SetActive(false);
        }

        for (int i = 0; i < quantityInputFields && i < _inputFields.Count; i++)
        {
            _inputFields[i].SetActive(true);
        }
    }

    public List<Toggle> Toggles()
    {
        return _toggles;
    }

    public List<int> QuantityInputFields()
    {
        return _quantityInputFields;
    }
}

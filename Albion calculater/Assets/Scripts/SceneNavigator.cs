using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class SceneNavigator : MonoBehaviour
{
    [SerializeField] private string CalculateScene;

    public void OpenCalculateScene()
    {
        SceneManager.LoadScene(CalculateScene);
    }
}

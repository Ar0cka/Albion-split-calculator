using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavigator : MonoBehaviour
{
   [SerializeField] private string NameCalculateScene;
   
   public void OpenAlbionCalculateScene()
   {
      SceneManager.LoadScene(NameCalculateScene);
   } 
}

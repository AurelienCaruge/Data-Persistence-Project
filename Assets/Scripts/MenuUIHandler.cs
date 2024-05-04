using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif


[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{

    public PlayerPrefs Newname;
    public bool UNITY_EDITOR { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    

    public void Exit()
    {

#if UNITY_EDITOR
        SceneManager.LoadScene(0);
#else
        Application.Quit();
#endif
        MainManager.Instance.SaveName();
    }

    public void Quit()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void SaveNameClicked()
    {
        MainManager.Instance.SaveName();
    }

    public void LoadNameClicked()
    {
        MainManager.Instance.LoadName();
    }
}

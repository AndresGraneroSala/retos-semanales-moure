using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenScene : MonoBehaviour
{
    [SerializeField] private string sceneLoad;

    public void GoScene()
    {
        SceneManager.LoadScene(sceneLoad);
    }
}

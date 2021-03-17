using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LoadSceneUI : MonoBehaviour
{
    public static LoadSceneUI Instance { get; private set; }

    [SerializeField]
    SceneLoaderSO sceneLoaderSO;
    [SerializeField]
    UnityEvent beginAction;

    SceneAnimancerController sceneAnimancerController;

    void Awake()
    {
        Instance = this;
        sceneAnimancerController = GetComponentInChildren<SceneAnimancerController>();
    }

    public void LoadScene(int index)
    {
        sceneAnimancerController.PlayFadeOut(() =>
        {
            sceneLoaderSO.LoadScene(index);
        });
    }

    public void LoadSameScene()
    {
        sceneAnimancerController.PlayFadeOut(() => { sceneLoaderSO.LoadSameScene(); });
    }
}

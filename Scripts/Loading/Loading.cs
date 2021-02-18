using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Text Text1;
    public Image Image;
    private static bool PlayAnimation = false;
    private static Loading defolt;
    private Animator componentAnimator;
    private AsyncOperation loadingSceneOperation;
    public static void Switch(string sceneName)
    {
        defolt.componentAnimator.SetTrigger(name: "Loading Start");

        defolt.loadingSceneOperation = SceneManager.LoadSceneAsync(sceneName);
        defolt.loadingSceneOperation.allowSceneActivation = false;
    }
    void Start()
    {
        defolt = this;
        componentAnimator = GetComponent<Animator>();

        if (PlayAnimation) componentAnimator.SetTrigger(name: "Loading End");
    }
    void Update()
    {
        if (loadingSceneOperation != null)
        {
            Text1.text = Mathf.RoundToInt(loadingSceneOperation.progress * 100) + "%";
            Image.fillAmount = loadingSceneOperation.progress;
        }
    }
    public void OnAnimationOver()
    {
        PlayAnimation = true;
        loadingSceneOperation.allowSceneActivation = true;
    }
}

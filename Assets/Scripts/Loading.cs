using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    [SerializeField]
    private Slider Slider;

    [SerializeField]
    private float waiSeconds = 2f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (waiSeconds > 0f)
            waiSeconds -= Time.deltaTime;
        else
            StartCoroutine(LoadNewScene());
    }
    private IEnumerator LoadNewScene()
    {
        AsyncOperation oper = SceneManager.LoadSceneAsync("Scene01");
        while (oper.isDone)
        {
            Slider.value = oper.progress / 0.9f;
            yield return null;
        }
    }
}

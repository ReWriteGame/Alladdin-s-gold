using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextLogic : MonoBehaviour
{
    [SerializeField] private float dalay;
    private TextList textList;

    private Coroutine coroutine = null;
    void Start()
    {
        textList = GetComponent<TextList>();
    }

    
    public void ShowRandomText()
    {
        textList.Texts[Random.Range(0,textList.Texts.Length)].gameObject.SetActive(true);
    }

    public void HideAllText()
    {
        for (int i = 0; i < textList.Texts.Length; i++)
            textList.Texts[i].gameObject.SetActive(false);
    }

    
    public void StartRandomShow()
    {
        if(coroutine != null)StopCoroutine(coroutine);
        coroutine = StartCoroutine(RandomShowerCor(dalay));
    }
    public void StopRandomShow()
    {
        if(coroutine != null)StopCoroutine(coroutine);
    }

  
    private IEnumerator RandomShowerCor(float time)
    {
        while (true)
        {
            HideAllText();
            ShowRandomText();
            yield return new WaitForSeconds(time);
        }
    }
}

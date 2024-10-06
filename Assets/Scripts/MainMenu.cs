using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject[] _windows;
    private float _waitDuration = 1f;
    private bool _done;

    void Start()
    {
        for (int i = 0; i < _windows.Length; i++)
            _windows[i].GetComponent<CanvasGroup>().alpha = 0;
        _windows[0].GetComponent<CanvasGroup>().alpha = 1;
        _done = false;
        StartCoroutine(ShowTitle(_windows));
    }

    IEnumerator ShowTitle(GameObject[] _windows)
    {
        _windows[0].GetComponent<CanvasGroup>().LeanAlpha(0f, 1);
        for (int i = 1; i < _windows.Length; i++)
        {
            float elapsed = 0f;
            
            _windows[i].GetComponent<CanvasGroup>().LeanAlpha(1f, 1);
            while (elapsed < _waitDuration && i != _windows.Length - 1)
            {
                elapsed += Time.deltaTime;
                yield return null;
            }
        }
        _done = true;
    }

    void Update()
    {
        if (_done)
        {
        }
    }


}

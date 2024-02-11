using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enabled : MonoBehaviour
{
    private Menu[] _menus;
    private void Start()
    {
        _menus = FindObjectsOfType<Menu>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Input.mousePosition;
            if (!RectTransformUtility.RectangleContainsScreenPoint(gameObject.GetComponent<RectTransform>(), mousePosition))
            {
                gameObject.SetActive(false);
                Debug.Log("панель скрыта");
                AnimationStop();
            }
        }
    }
    public void Enable()
    {
        gameObject.SetActive(true);
    }

    private void AnimationStop()
    {
        _menus[0].AnimationStop();
        _menus[1].AnimationStop();
    }
}

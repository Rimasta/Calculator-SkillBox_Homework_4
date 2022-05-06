using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField] private GameObject firstScreen;
    [SerializeField] private GameObject secondScreen;

    private GameObject _currentScreen;

    private void Start()
    {
        firstScreen.SetActive(true);
        _currentScreen = firstScreen;
    }

    public void ChangeState(GameObject state)
    {
        if (_currentScreen != null)
        {
            _currentScreen.SetActive(false);
            state.SetActive(true);
            _currentScreen = state;
        }
    }
}

using System;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public event Action OnPushStart;

[SerializeField] GameObject _buttonStart;

public void ShowStartMenuButtons()
{
    _buttonStart.active = true;
}

public void PushStartButton()
{
    OnPushStart?.Invoke();
    _buttonStart.active = false;

}
}

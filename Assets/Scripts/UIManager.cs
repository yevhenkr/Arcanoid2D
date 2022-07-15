using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    Counter counter;
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
        counter.AddedCount();
}


}

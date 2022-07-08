using System;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public event Action OnPushStart;

    public void PushStartButton()
    {
        OnPushStart?.Invoke();
    }
}

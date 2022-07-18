using TMPro;
using UnityEngine;

public class CounterPanel : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI counter;
    [SerializeField]
    int zero;

    private int count;
    public void ResetValue()
    {
        counter.text = zero.ToString();
    }
    public void AddedCount()
    {
        int.TryParse(counter.text, out count);
        count++;
        counter.text = count.ToString();
    }
}

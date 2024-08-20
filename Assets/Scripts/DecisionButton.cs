using UnityEngine;
using UnityEngine.UI;

public class DecisionButton : MonoBehaviour
{
    public Image imgComp;
    public Color activeColor;
    public Color normalColor;

    public void ActiveClick()
    {
        if (imgComp)
        {
            imgComp.color = activeColor;
            Debug.Log("Button activated: " + gameObject.name);
        }
    }
    public void DeactiveClick()
    {
        if (imgComp)
        {
            imgComp.color = normalColor;
            Debug.Log("Button deactivated: " + gameObject.name);
        }
    }
}

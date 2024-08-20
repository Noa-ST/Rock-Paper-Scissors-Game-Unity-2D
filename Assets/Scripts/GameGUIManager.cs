using UnityEngine;
using UnityEngine.UI;

public class GameGUIManager : Singleton<GameGUIManager>
{
    public Sprite rockSprite;
    public Sprite paperSprite;
    public Sprite scissorsSprite;

    public Text resultText;
    public DecisionButton[] decisionButtons;

    public override void Awake()
    {
        MakeSingleton(false);
    }

    public void UpdateResult(string result)
    {
        if (resultText)
        {
            resultText.gameObject.SetActive(true);
            resultText.text = result;
            Debug.Log("Result updated: " + result);
        }
    }

    public void DeactiveDecisionBtns()
    {
        if (decisionButtons != null && decisionButtons.Length > 0)
        {
            for (int i = 0; i < decisionButtons.Length; i++)
            {
                DecisionButton decisionButton = decisionButtons[i];
                if (decisionButton)
                {
                    decisionButton.DeactiveClick();
                    decisionButton.imgComp.gameObject.SetActive(true);
                }
            }
            Debug.Log("All decision buttons deactivated");
        }

    }

    public void ReactivateDecisionBtns()
    {
        if (decisionButtons != null && decisionButtons.Length > 0)
        {
            for (int i = 0; i < decisionButtons.Length; i++)
            {
                DecisionButton decisionButton = decisionButtons[i];
                if (decisionButton)
                {
                    decisionButton.ActiveClick();
                }
            }
            Debug.Log("All decision buttons reactivated");
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

public class AIController : MonoBehaviour
{
    public int curDecision;
    public Image decisionIcon;
    public Image questionMark;

    public void ShowDecisionIcon(bool isShow)
    {
        if (decisionIcon)
        {
            decisionIcon.gameObject.SetActive(isShow);

            if (questionMark)
                questionMark.gameObject.SetActive(!isShow);

            Debug.Log("Decision icon visibility set to: " + isShow);
        }
    }

    public void MakeDecision()
    {
        curDecision = Random.Range(1, 4);

        ShowDecisionIcon(true);

        switch (curDecision)
        {
            case Const.ROCK:
                if (decisionIcon)
                    decisionIcon.sprite = GameGUIManager.Ins.rockSprite;
                Debug.Log("AI decision: ROCK");
                break;
            case Const.PAPER:
                if (decisionIcon)
                    decisionIcon.sprite = GameGUIManager.Ins.paperSprite;
                Debug.Log("AI decision: PAPER");
                break;
            case Const.SCISSIOR:
                if (decisionIcon)
                    decisionIcon.sprite = GameGUIManager.Ins.scissorsSprite;
                Debug.Log("AI decision: SCISSORS");
                break;
        }
    }
}

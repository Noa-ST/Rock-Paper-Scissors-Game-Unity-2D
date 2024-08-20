using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public AIController ai;

    private void Start()
    {
        AudioController.Ins.PlayBackgroundMusic();
    }

    public void CheckPlayerDecision(int decision)
    {
        if (ai == null)
        {
            Debug.LogError("AI Controller is not assigned");
            return;
        }

        ai.MakeDecision();

        string result = "";

        switch (decision)
        {
            case Const.ROCK:
                switch (ai.curDecision)
                {
                    case Const.ROCK:
                        result = "DRAW!!!";
                        AudioController.Ins.PlaySound(AudioController.Ins.drawSound);
                        break;
                    case Const.PAPER:
                        result = "YOU LOSE!!!";
                        AudioController.Ins.PlaySound(AudioController.Ins.loseSound);
                        break;
                    case Const.SCISSIOR:
                        result = "YOU WIN!!!";
                        AudioController.Ins.PlaySound(AudioController.Ins.winSound);
                        break;
                }
                break;
            case Const.PAPER:
                switch (ai.curDecision)
                {
                    case Const.PAPER:
                        result = "DRAW!!!";
                        AudioController.Ins.PlaySound(AudioController.Ins.drawSound);
                        break;
                    case Const.SCISSIOR:
                        result = "YOU LOSE!!!";
                        AudioController.Ins.PlaySound(AudioController.Ins.loseSound);
                        break;
                    case Const.ROCK:
                        result = "YOU WIN!!!";
                        AudioController.Ins.PlaySound(AudioController.Ins.winSound);
                        break;
                }
                break;
            case Const.SCISSIOR:
                switch (ai.curDecision)
                {
                    case Const.SCISSIOR:
                        result = "DRAW!!!";
                        AudioController.Ins.PlaySound(AudioController.Ins.drawSound);
                        break;
                    case Const.ROCK:
                        result = "YOU LOSE!!!";
                        AudioController.Ins.PlaySound(AudioController.Ins.loseSound);
                        break;
                    case Const.PAPER:
                        result = "YOU WIN!!!";
                        AudioController.Ins.PlaySound(AudioController.Ins.winSound);
                        break;
                }
                break;
        }

        GameGUIManager.Ins.UpdateResult(result);
        Debug.Log("Result: " + result);

        StartCoroutine(Replay());
    }

    IEnumerator Replay()
    {
        yield return new WaitForSeconds(2f);

        if (ai)
        {
            ai.ShowDecisionIcon(false);
        }

        GameGUIManager.Ins.resultText.gameObject.SetActive(false);
        GameGUIManager.Ins.DeactiveDecisionBtns();
    }
}

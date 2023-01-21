using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AnswerChecker : MonoBehaviour
{
    [SerializeField] private CorrectAnswerCount _correctAnswer;
    [SerializeField] private TMP_Text _textCountAttempts;
    [SerializeField] private QuestionDisplay _gameController;
    [SerializeField] private PanelController _panelController;

    private int _countAttempts = 3;

    private void Start()
    {
        _textCountAttempts.text = _countAttempts + "";
    }

    public void OnClickButton(int buttonId)
    {
        if (CheckAnswer(_gameController.SelectedQuetion, _gameController.AnswerButtons[buttonId]))
        {
            if (_gameController.Questions.Count == 0)
            {
                _panelController.WinGame();
            }

            _correctAnswer.AddCorrectAnswer();
            _gameController.SelectQuestion();
        }
        else
        {
            _countAttempts--;
            _textCountAttempts.text = _countAttempts + "";

            if (_countAttempts <= 0)
            {
                _panelController.OnGameOver();
            }

            if (_gameController.Questions.Count == 0)
            {
                _panelController.WinGame();
            }

            _gameController.SelectQuestion();
        }
    }

    private bool CheckAnswer(Question question, Button button)
    {
        if (button.GetComponentInChildren<TextMeshProUGUI>().text == question.correctAnswer)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

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

    public void OnClickButton(int buttonId) // обработчик нажатия на кнопки ответов с параметром номера кнопки
    {
        if (CheckAnswer(_gameController.SelectedQuetion, _gameController.AnswerButtons[buttonId])) // проверка правельности ответа
        {
            if (_gameController.Questions.Count == 0)
            {
                _panelController.WinGame();
            }

            _correctAnswer.AddCorrectAnswer(); // увеличиваем количество верных ответов
            _gameController.SelectQuestion(); // перехолд к следующему вопросу
        }
        else
        {
            _countAttempts--; // уменьшаем количество попыток
            _textCountAttempts.text = _countAttempts + "";

            if (_countAttempts <= 0) // если попыток нет
            {
                _panelController.OnGameOver(); // запуск панели проигрыша
            }

            if (_gameController.Questions.Count == 0) // если вопросов нет
            {
                _panelController.WinGame(); // запуск панели победы
            }

            _gameController.SelectQuestion(); // перехолд к следующему вопросу
        }
    }

    private bool CheckAnswer(Question question, Button button) // проверка верности ответа
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

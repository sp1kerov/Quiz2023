using UnityEngine;
using TMPro;

public class RandomQuestion : MonoBehaviour
{
    [SerializeField] private QuestionDisplay _questionDisplay; 
    [SerializeField] private TMP_Text _textQuestionStatus;

    private void Start()
    {
        CheckQuestionDisplayStatus();
    }

    public void ChageQuestionTypeDisplay() // сменить тип вподбора вопросов
    {
        _questionDisplay.RandomQuestionSwitcher();
        CheckQuestionDisplayStatus();
    }

    private void CheckQuestionDisplayStatus() // смена текста на кнопки включения рандомного подбора вопросов
    {
        if (_questionDisplay.OnRandomQuestion == false)
        {
            _textQuestionStatus.text = "ВЫКЛ";
        }
        else
        {
            _textQuestionStatus.text = "ВКЛ";
        }

    }
}

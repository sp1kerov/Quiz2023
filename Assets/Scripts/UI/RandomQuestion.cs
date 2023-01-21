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

    public void ChageQuestionTypeDisplay()
    {
        _questionDisplay.RandomQuestionSwitcher();
        CheckQuestionDisplayStatus();
    }

    private void CheckQuestionDisplayStatus()
    {
        if (_questionDisplay.OnRandomQuestion == false)
        {
            _textQuestionStatus.text = "¬€ À";
        }
        else
        {
            _textQuestionStatus.text = "¬ À";
        }

    }
}

using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Button = UnityEngine.UI.Button;

public class QuestionDisplay : MonoBehaviour
{
    [SerializeField] private QuestionDataScriptable _questionDataScriptable; // ��������� ��������
    [SerializeField] private TMP_Text _questionText; // ����� �������
    [SerializeField] private List<Button> _answerButtons; // ������ �������
    [SerializeField] private bool _onRandomQuestion = false; // �������

    public List<Button> AnswerButtons => _answerButtons;
    public List<Question> Questions => _questions;
    public Question SelectedQuetion => _selectedQuetion;
    public bool OnRandomQuestion => _onRandomQuestion;

    private List<Question> _questions = new List<Question>(); // ��������� ��������
    private Question _selectedQuetion = new Question(); // ������ �������

    private void Start()
    {
        _questions.AddRange(_questionDataScriptable.questions);
        SelectQuestion();
    }

    public void RandomQuestionSwitcher()
    {
        if (_onRandomQuestion == false)
        {
            _onRandomQuestion = true;
        }
        else
        {
            _onRandomQuestion = false;
        }
    }

    public void SelectQuestion()
    {
        if (_questions.Count > 0)
        {
            if (_onRandomQuestion == true)
            {
                int indexQuestion = Random.Range(0, _questions.Count);
                _selectedQuetion = _questions[indexQuestion];
                SetQuestion(_selectedQuetion);
                SetButtons(_selectedQuetion);
                _questions.RemoveAt(indexQuestion);
            }
            else
            {
                _selectedQuetion = _questions[0];
                SetQuestion(_selectedQuetion);
                SetButtons(_selectedQuetion);
                _questions.RemoveAt(0);
            }
        }        
    }

    private void SetQuestion(Question question)
    {
        _questionText.text = question.questionText;
    }

    private void SetButtons(Question question)
    {
        for (int i = 0; i < _answerButtons.Count; i++)
        {
            _answerButtons[i].GetComponentInChildren<TextMeshProUGUI>().text = question.answers[i];
        }
    }
}

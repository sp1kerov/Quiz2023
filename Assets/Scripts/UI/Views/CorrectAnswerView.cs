using TMPro;
using UnityEngine;

public class CorrectAnswerView : MonoBehaviour
{
    [SerializeField] private TMP_Text _textCorrectAnswer;
    [SerializeField] private CorrectAnswerCount _correctAnswerCount;

    private void Start()
    {
        ShowCountCorrentAnswer(_correctAnswerCount.CountCorrectAnswer); // при включении панели отобразить количество верных ответов
    }

    public void ShowCountCorrentAnswer(int correctAnswerCount)
    {
        _textCorrectAnswer.text = correctAnswerCount + "";
    }
}

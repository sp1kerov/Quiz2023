using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectAnswerCount : MonoBehaviour
{
    [SerializeField] private CorrectAnswerView _correctAnswerView;

    public int CountCorrectAnswer => _correctAnswerCount;

    private const string _keyBestCountCorrectAnswer = "Best Count Correct Answer";

    private int _correctAnswerCount = 0;
    private int _bestCountCorrectAnswer;
        
    public void AddCorrectAnswer()
    {
        _correctAnswerCount++;

        if (_correctAnswerCount > PlayerPrefs.GetInt(_keyBestCountCorrectAnswer))
        {
            _bestCountCorrectAnswer = _correctAnswerCount;
            PlayerPrefs.SetInt(_keyBestCountCorrectAnswer, _bestCountCorrectAnswer);
        }

        _correctAnswerView.ShowCountCorrentAnswer(_correctAnswerCount);
    }
}

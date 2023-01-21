using UnityEngine;

public class CorrectAnswerCount : MonoBehaviour
{
    [SerializeField] private CorrectAnswerView _correctAnswerView;

    public int CountCorrectAnswer => _correctAnswerCount;

    private const string _keyBestCountCorrectAnswer = "Best Count Correct Answer";

    private int _correctAnswerCount = 0; // колчиство верных ответов
    private int _bestCountCorrectAnswer;
        
    public void AddCorrectAnswer() // увеличиваем количество верных ответов
    {
        _correctAnswerCount++;

        if (_correctAnswerCount > PlayerPrefs.GetInt(_keyBestCountCorrectAnswer)) // если количество верных ответов больше чем получено раннее то
        {
            _bestCountCorrectAnswer = _correctAnswerCount;
            PlayerPrefs.SetInt(_keyBestCountCorrectAnswer, _bestCountCorrectAnswer); // сохраняем новое количество верных ответов
        }

        _correctAnswerView.ShowCountCorrentAnswer(_correctAnswerCount); // отобразить количество верных ответов
    }
}

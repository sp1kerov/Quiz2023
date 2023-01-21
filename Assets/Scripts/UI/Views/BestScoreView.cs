using TMPro;
using UnityEngine;

public class BestScoreView : MonoBehaviour
{
    [SerializeField] private TMP_Text _textCorrectAnswer;

    private const string _keyBestCountCorrectAnswer = "Best Count Correct Answer";

    private void Start() // ���������� ������ ���� �� ������ ����
    {
        if (!PlayerPrefs.HasKey(_keyBestCountCorrectAnswer))
        {
            PlayerPrefs.SetInt(_keyBestCountCorrectAnswer, 0);
        }

        _textCorrectAnswer.text = PlayerPrefs.GetInt(_keyBestCountCorrectAnswer) + "";
    }
}

using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    [SerializeField] private PanelGame _panelGame; // текст времени
    [SerializeField] private TMP_Text _textTime; // текст времени

    public TimeSpan TIme => _time;

    private float _currentSeconds = 0;
    private TimeSpan _time;

    private void Update()
    {
        if (_panelGame.gameObject.activeSelf == true)
        {
            _currentSeconds += Time.deltaTime; // подсчет секунд
            _time = TimeSpan.FromSeconds(_currentSeconds); // конвертация в игровое время
            _textTime.text = _time.ToString("mm':'ss"); // задаем вид отображен7ия времени
        }
    }

}

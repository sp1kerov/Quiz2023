using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    [SerializeField] private PanelGame _panelGame; // ����� �������
    [SerializeField] private TMP_Text _textTime; // ����� �������

    public TimeSpan TIme => _time;

    private float _currentSeconds = 0;
    private TimeSpan _time;

    private void Update()
    {
        if (_panelGame.gameObject.activeSelf == true)
        {
            _currentSeconds += Time.deltaTime; // ������� ������
            _time = TimeSpan.FromSeconds(_currentSeconds); // ����������� � ������� �����
            _textTime.text = _time.ToString("mm':'ss"); // ������ ��� ���������7�� �������
        }
    }

}

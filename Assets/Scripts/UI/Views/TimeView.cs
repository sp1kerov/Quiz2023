using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeView : MonoBehaviour
{
    [SerializeField] private Timer timer;
    [SerializeField] private TMP_Text _textTime; // текст времени

    private void Start()
    {
        _textTime.text = timer.TIme.ToString("mm':'ss");
    }
}

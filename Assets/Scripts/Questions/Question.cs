using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Question
{
    public string questionText; // текст вопроса
    public List<string> answers; // варианты ответов
    public string correctAnswer; // правильный ответ
}

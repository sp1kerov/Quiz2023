using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AddQuestions", menuName = "AddQuestions", order = 1)] // добьавление пункта меню для создания вопроса
public class QuestionDataScriptable : ScriptableObject
{
    public List<Question> questions; // список вопросов
}

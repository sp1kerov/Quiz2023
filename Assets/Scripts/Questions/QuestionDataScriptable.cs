using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AddQuestions", menuName = "AddQuestions", order = 1)] // ����������� ������ ���� ��� �������� �������
public class QuestionDataScriptable : ScriptableObject
{
    public List<Question> questions; // ������ ��������
}

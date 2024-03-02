using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelManager : MonoBehaviour
{
    [Header("Level Data")]
    public Subject Lesson;

    [Header("User Interface")]
    public TMP_Text QuestionTxt;
    public List<OptionBtm> Options;

    [Header("Game Configuration")]
    public int questionAmount = 0;
    public int currentQuestion = 0;
    public string question;
    public string correctAnswer;

    [Header("Current Lesson")]
    public Leccion currentLesson;

    // Start is called before the first frame update
    void Start()
    {
        //Establecemos la cantidad de preguntas en la leccion
        questionAmount = Lesson.leccionList.Count;
        //Cargar la primera pergunta
        LoadQuestion();
    }

    private void LoadQuestion()
    {
        //Aseguramos que la pregunta actual esta dentro de los limites
        if(currentQuestion < questionAmount) 
        {
            //Establecemos la leccíon actual
            currentLesson = Lesson.leccionList[currentQuestion];
            //Establecemos la pregunta
            question = currentLesson.lessons;
            //Establecemos la respuesta correcta
            correctAnswer = currentLesson.options[currentLesson.correctAnswer];
            //Establecemos la pregunta en UI
            QuestionTxt.text = question;
            //Establecemos las Opciones
            Options[0].GetComponent<OptionBtm>().OptionName = currentLesson.options[0];
        }
        else
        {
            //Si llegamos al final de las preguntas
            Debug.Log("Fin de las preguntas");
           
        }
    }

    public void NextCuestion()
    {
        if(currentQuestion < questionAmount) 
        {
            //incrementamos el indice de la pregunta actual
            currentQuestion++;
            //Cargar la nueva pregunta
            LoadQuestion();
        }
        else
        {
            //Cambio de escena
        }
    }
}

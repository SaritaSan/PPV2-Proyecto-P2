using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LessonContainer : MonoBehaviour
{
    //Header= nos ayuda a clasificar y separar nuestras variables en el inspector por medio de etiquetas 
    [Header("GameObject Configuration")]
    //aquí vamos a personalizar desde el inspector toda nuestra informacion que va a aparecer en el UI
    public int lection = 0;
    public int currentLession = 0;
    public int totalLession = 0;
    public bool areAllLessonsComplete = false;

    [Header("UI Configuration")]
    //estas variables TMP_Text ya están creadas en el canva, esas se enlazarán con estas
    public TMP_Text stageTitle;
    public TMP_Text lessonStage;

    [Header("External GameObject Configuration")]
    //esta es nuestra imagen principal que contiene las UI de los textos y el boton
    public GameObject lessonContainer;

    [Header("Lesson Data")]
    public ScriptableObject lessonData;


    // Start is called before the first frame update
    void Start()
    {
        //este va a verificar si nuestra imagen UI principal con toda nuestra infomacion está ligada en el inspector
        if(lessonContainer != null)
        {
            OnUpdateUI();
        }
        else
        {
            Debug.LogWarning("GameObject Nulo, revisa las variables de tipo GameObject lessonContainer");
        }
    }

    public void OnUpdateUI()
    {
        //este va a verificar que nuestros textos estan ligados a nuestro inspector en sus variables correspondientes
        if(stageTitle != null || lessonContainer != null) 
        {
            //Los .text solo funcionan con variables TMP_Stage
            stageTitle.text = "Leccion " + lection;
            lessonStage.text = "Leccion " + currentLession + " de " + totalLession;
        }
        else
        {
            Debug.LogWarning("GameObject Nulo, revisa las variable de tipo TMP_Text");
        }
    }

    //Esta es una funcion o metodo que nosotros creamos para personalizar por nuestra cuenta un evento
    //este metodo especificamente activa/desactiva la ventana de lessonContainer
    public void EnableWindow()
    {
        OnUpdateUI();
                            //activeSelf es si está activado
        if(lessonContainer.activeSelf)
        {
            //desactiva el objeto si está activo
            lessonContainer.SetActive(false);
        }
        else
        {
            //activa el objeto si está desactivado
            lessonContainer.SetActive(true);
        }
    }
}

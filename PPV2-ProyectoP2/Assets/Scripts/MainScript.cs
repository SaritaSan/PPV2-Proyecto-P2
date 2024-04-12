using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainScript : MonoBehaviour
{
    public static MainScript instance;
    public string SelectedLesson = "dummy";

    [Header("External GameObject Configuration")]
    //esta es nuestra imagen principal que contiene la UI 
    public GameObject creditos;
    public GameObject cofre;


    private void Awake()
    {
        if(instance != null)
        {
            return;
        }
        else
        {
            instance = this;
        }
    }

    public void SetSelectedLesson(string lesson)
    {
        SelectedLesson = lesson;
        PlayerPrefs.SetString("SelectedLesson", SelectedLesson);
    }

    public void BeginGame()
    {
        SceneManager.LoadScene("Lesson");
    }

    public void DatesInteresting()
    {
        SceneManager.LoadScene("Novedades");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Main");
    }



    public void EnableWindow()
    {
        //activeSelf es si est� activado
        if (creditos.activeSelf)
        {
            //desactiva el objeto si est� activo
            creditos.SetActive(false);
        }
        else
        {
            //activa el objeto si est� desactivado
            creditos.SetActive(true);
            //MainScript.instance.SetSelectedLesson(LessonName);
        }
    }
    public void Cofre()
    {
        //activeSelf es si est� activado
        if (cofre.activeSelf)
        {
            //desactiva el objeto si est� activo
            cofre.SetActive(false);
        }
        else
        {
            //activa el objeto si est� desactivado
            cofre.SetActive(true);
            //MainScript.instance.SetSelectedLesson(LessonName);
        }
    }

    public void QuitAplication()
    {
        if (Input.GetMouseButtonDown(0)) // Verifica si se hace clic con el bot�n izquierdo del mouse
        {
            Application.Quit(); // Cierra la aplicaci�n
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

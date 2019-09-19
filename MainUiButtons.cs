using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement ;

public class MainUiButtons : MonoBehaviour
{
    public GameObject optionsCanvas, mainCanvas, questionCanvas, editorCanvas;
    public ScrollRect scrollPanel;
    public PopulateQuestionScroll questionScroll;

    private void Start()
    {
        optionsCanvas.SetActive(false);
    }

    public void PauseButtonPressed(bool pausePressed)
    {
        optionsCanvas.SetActive(pausePressed);
    }

    public void CustomEditorButtonPressed()
    {
        questionScroll.LoadQuestions();
        editorCanvas.SetActive(true);
        mainCanvas.SetActive(false);
        questionCanvas.SetActive(false);
        optionsCanvas.SetActive(false);
    }

    public void NewGamemodeButtonPressed()
    {
        optionsCanvas.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ReturnToMainGame()
    {
        optionsCanvas.SetActive(false);
        editorCanvas.SetActive(false);
        mainCanvas.SetActive(true);
        questionCanvas.SetActive(true);
    }

    
}

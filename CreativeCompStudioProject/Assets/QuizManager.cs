using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QuestionsAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject Quizpanel;
    public GameObject GameOverPanel;
    public GameObject CongratsPanel;
    public Text QuestionTxt;
    public Text ScoreTxt;

    public string flute = "FluteWin";
    public string trumpet = "TrumpetWin";


    int totalQuestions = 0;
    public int score;

    private void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        totalQuestions = QnA.Count;
        GameOverPanel.SetActive(false);
        generateQuestion();
        int trumpetWin = PlayerPrefs.GetInt("TrumpetWin");
        int fluteWin = PlayerPrefs.GetInt("FluteWin");
        if(trumpetWin == 1 && scene.name == "GreatPlainsQuiz"){
            PlayerPrefs.SetInt(trumpet,0);
        }
        if(trumpetWin == 1 && scene.name == "NewOrleansQuiz"){
            PlayerPrefs.SetInt(flute,0);
        }
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameOver()
    {
        Scene scene = SceneManager.GetActiveScene();
        //int trumpetWin = PlayerPrefs.GetInt("TrumpetWin");
        Quizpanel.SetActive(false);
        GameOverPanel.SetActive(true);
        ScoreTxt.text = score + "/" + totalQuestions;
        if (score == 3 && GameOverPanel.activeInHierarchy)
        {
            Quizpanel.SetActive(false);
            GameOverPanel.SetActive(false);
            CongratsPanel.SetActive(true);
            if (scene.name == "GreatPlainsQuiz"){
                PlayerPrefs.SetInt(flute, 1);
            }
            if (scene.name == "NewOrleansQuiz"){
                PlayerPrefs.SetInt(trumpet, 1);
            }
        }
    }

    void generateQuestion()
    {
        if (QnA.Count > 0)
        {
            currentQuestion = Random.Range(0, QnA.Count);
            QuestionTxt.text = QnA[currentQuestion].Question;
            SetAnswers();
        }
        else
        {
            Debug.Log("Out Of Questions");
            GameOver();
        }
    }

    public void correct()
    {
        score += 1;
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void wrong()
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestion();

    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }
}

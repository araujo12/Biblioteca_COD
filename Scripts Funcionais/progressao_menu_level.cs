using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsWindows : MonoBehaviour {

    public GameObject starpoints1, starpoints2, starpoints3;
    public int StarPoints = 0;
    public GameObject statswindows1, statswindows2, statswindows3, statswindows4, statswindows5, statswindows6, statswindows7, statswindows8, statswindows9;
    public Slider slider;
    public GameObject buttonsQuest1, buttonsQuest2, buttonsQuest3, buttonsQuest4, buttonsQuest5, buttonsQuest6, buttonsQuest7, buttonsQuest8, buttonsQuest9;
    public GameObject planeta1, planeta2, planeta3, planeta4, planeta5, planeta6, planeta7, planeta8, planeta9;
    public GameObject arco1, arco2, arco3, arco4, arco5, arco6, arco7, arco8;
    public GameObject buttonHome;
    public float Score;
    public Text pontos, tempo;
    public float Tempo = 0f;




    // Use this for initialization
    void Start () {        

        statswindows1.SetActive(false);
        statswindows2.SetActive(false);
        statswindows3.SetActive(false);
        statswindows4.SetActive(false);
        statswindows5.SetActive(false);
        statswindows6.SetActive(false);
        statswindows7.SetActive(false);
        statswindows8.SetActive(false);
        statswindows9.SetActive(false);
        starpoints1.SetActive(false);
        starpoints2.SetActive(false);
        starpoints3.SetActive(false);
        buttonsQuest1.SetActive(true);
        buttonsQuest2.SetActive(false);
        buttonsQuest3.SetActive(false);
        buttonsQuest4.SetActive(false);
        buttonsQuest5.SetActive(false);
        buttonsQuest6.SetActive(false);
        buttonsQuest7.SetActive(false);
        buttonsQuest8.SetActive(false);
        buttonsQuest9.SetActive(false);
        planeta1.SetActive(false);
        planeta2.SetActive(false);
        planeta3.SetActive(false);
        planeta4.SetActive(false);
        planeta5.SetActive(false);
        planeta6.SetActive(false);
        planeta7.SetActive(false);
        planeta8.SetActive(false);
        planeta9.SetActive(false);
        arco1.SetActive(false);
        arco2.SetActive(false);
        arco3.SetActive(false);
        arco4.SetActive(false);
        arco5.SetActive(false);
        arco6.SetActive(false);
        arco7.SetActive(false);
        arco8.SetActive(false);
        buttonHome.SetActive(false);
        

    }
	
	// Update is called once per frame
	void Update () {

        Tempo = Time.deltaTime;
        CountPoint();
        CompletBar();
        ShowScore();
        ShowTime();
	}

    //Abrir a tela de perguntas
    public void CheckWindows1()
    {
        if(statswindows1.activeSelf == false)
        {
            statswindows1.SetActive(true);            
        }
        else
        {
            statswindows1.SetActive(false);            
        }        
    }

    public void CheckWindows2()
    {
        if (statswindows2.activeSelf == false)
        {
            statswindows2.SetActive(true);
        }
        else
        {
            statswindows2.SetActive(false);
        }
    }

    public void CheckWindows3()
    {
        if (statswindows3.activeSelf == false)
        {
            statswindows3.SetActive(true);
        }
        else
        {
            statswindows3.SetActive(false);
        }
    }

    public void CheckWindows4()
    {
        if (statswindows4.activeSelf == false)
        {
            statswindows4.SetActive(true);
        }
        else
        {
            statswindows4.SetActive(false);
        }
    }

    public void CheckWindows5()
    {
        if (statswindows5.activeSelf == false)
        {
            statswindows5.SetActive(true);
        }
        else
        {
            statswindows5.SetActive(false);
        }
    }

    public void CheckWindows6()
    {
        if (statswindows6.activeSelf == false)
        {
            statswindows6.SetActive(true);
        }
        else

        {
            statswindows6.SetActive(false);
        }
    }

    public void CheckWindows7()
    {
        if (statswindows7.activeSelf == false)
        {
            statswindows7.SetActive(true);
        }
        else
        {
            statswindows7.SetActive(false);
        }
    }

    public void CheckWindows8()
    {
        if (statswindows8.activeSelf == false)
        {
            statswindows8.SetActive(true);
        }
        else
        {
            statswindows8.SetActive(false);
        }
    }

    public void CheckWindows9()
    {
        if (statswindows9.activeSelf == false)
        {
            statswindows9.SetActive(true);
        }
        else
        {
            statswindows9.SetActive(false);
        }
    }

    //Ativação das perguntas
    public void CheckQuest1()
    {
        if(planeta1.activeSelf == false)
        {
            planeta1.SetActive(true);
            buttonsQuest2.SetActive(true);
            arco1.SetActive(true);            
            buttonsQuest1.SetActive(false);
            Score += 1;
        }
    }

    public void CheckQuest2()
    {
        if (planeta2.activeSelf == false)
        {
            planeta2.SetActive(true);
            arco2.SetActive(true);
            buttonsQuest3.SetActive(true);
            buttonsQuest2.SetActive(false);
            Score += 1;
        }
    }

    public void CheckQuest3()
    {
        if (planeta3.activeSelf == false)
        {
            planeta3.SetActive(true);
            arco3.SetActive(true);
            buttonsQuest4.SetActive(true);
            buttonsQuest3.SetActive(false);
            Score += 1;
        }
    }

    public void CheckQuest4()
    {
        if (planeta4.activeSelf == false)
        {
            planeta4.SetActive(true);
            arco4.SetActive(true);
            buttonsQuest5.SetActive(true);
            buttonsQuest4.SetActive(false);
            Score += 1;
        }
    }

    public void CheckQuest5()
    {
        if (planeta5.activeSelf == false)
        {
            planeta5.SetActive(true);
            arco5.SetActive(true);
            buttonsQuest6.SetActive(true);
            buttonsQuest5.SetActive(false);
            Score += 1;
        }
    }

    public void CheckQuest6()
    {
        if (planeta6.activeSelf == false)
        {
            planeta6.SetActive(true);
            arco6.SetActive(true);
            buttonsQuest7.SetActive(true);
            buttonsQuest6.SetActive(false);
            Score += 1;
        }
    }

    public void CheckQuest7()
    {
        if (planeta7.activeSelf == false)
        {
            planeta7.SetActive(true);
            arco7.SetActive(true);
            buttonsQuest8.SetActive(true);
            buttonsQuest7.SetActive(false);
            Score += 1;
        }
    }

    public void CheckQuest8()
    {
        if (planeta8.activeSelf == false)
        {
            planeta8.SetActive(true);
            arco8.SetActive(true);
            buttonsQuest9.SetActive(true);
            buttonsQuest8.SetActive(false);
            Score += 1;
        }
    }

    public void CheckQuest9()
    {
        if (planeta9.activeSelf == false)
        {
            planeta9.SetActive(true);
            buttonsQuest9.SetActive(false);
            buttonHome.SetActive(true);
            Score += 1;
        }
    }

    //Quando acertar a resposta
    public void CorrectAnswer()
    {
        StarPoints += 1;
    }

    //Somador de pontos
    public void CountPoint()
    {
        if(starpoints1.activeSelf == false)
        {
            if(StarPoints >= 3)
            {
                starpoints1.SetActive(true);
            }
        }
        if (starpoints2.activeSelf == false)
        {
            if (StarPoints >= 6)
            {
                starpoints2.SetActive(true);
            }
        }
        if (starpoints3.activeSelf == false)
        {
            if (StarPoints >= 9)
            {
                starpoints3.SetActive(true);
            }
        }
    }

    //Completar a barra de pontos
    public void CompletBar()
    {
        slider.value = StarPoints;
    }

    //Mostrador do Score
    public void ShowScore()
    {
        pontos.text = Score.ToString();
    }

    //Mostrador do Tempo
    public void ShowTime()
    {
        tempo.text = Tempo.ToString("F2");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public GameObject PainelOpcoes;

    public void BotaoJogar()
    {
        SceneManager.LoadScene("primeiro");
    }

    public void BotaoOpcoes()
    {
        PainelOpcoes.SetActive(true);
    }

    public void BotaoVoltar()
    {
        SceneManager.LoadScene("Menu");
    }

    public void BotaoSair()
    {
        Application.Quit();

    }
}

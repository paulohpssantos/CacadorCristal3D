using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public TMP_Text textoPontuacao;
    public GameObject painelVitoria;

    private int cristaisColetados = 0;
    private int totalCristais = 5;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        AtualizaPontuacao();
        painelVitoria.SetActive(false);
    }
    
    public void ColetarCristal()
    {
        cristaisColetados++;
        AtualizaPontuacao();

        if(cristaisColetados >= totalCristais)
        {
            VencerJogo();
        }
    }
    void AtualizaPontuacao()
    {
        textoPontuacao.text = 
        "Cristais: " +cristaisColetados+ " / " + totalCristais;
    }
    void VencerJogo()
    {
        painelVitoria.SetActive(true);
        Time.timeScale = 0f;
    }
}

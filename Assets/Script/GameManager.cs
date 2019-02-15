using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager NewInstance;

    public TextMeshProUGUI txtTime;
    public Text textStageTime;
    public Text txtScene;
    public int PlayerDeaths;
    public float stageTime = 20.0f;

    private void Awake()
    {
        if (NewInstance == null)
            NewInstance = this;
        else if (NewInstance != this)
            Destroy(gameObject);

        txtScene.text = SceneManager.GetActiveScene().name;
    }

    void Update()
    {
        TempoSetup();
        DecreasingTime();
    }

    private void TempoSetup() {
        float Tempo = Time.time;

        string minutos = ((int)Tempo / 60).ToString();
        string segundos = (Tempo % 60).ToString("f0");

        if ((Tempo % 60) < 9.5f)
            txtTime.text = minutos + " : 0" + segundos;
        else
            txtTime.text = minutos + " : " + segundos;
    }

    public void DecreasingTime() {

        if (stageTime > 0) {
            stageTime -= Time.deltaTime;
        } else {
            stageTime = 0;
        }

        textStageTime.text = stageTime.ToString("f1");
    }
}

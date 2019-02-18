using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoKeeper : MonoBehaviour
{
    public static InfoKeeper instance;

    public float TimeLevel;

    private void Awake() {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(this);
        TimeLevel = GameManager.NewInstance.stageTime;
    }

    void Start() {
        TimeLevel = GameManager.NewInstance.stageTime;
    }

    void Update() {

    }
}
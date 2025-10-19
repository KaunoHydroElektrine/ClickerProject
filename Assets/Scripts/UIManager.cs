using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField]
    private TextMeshProUGUI clickText;
    [SerializeField]
    private TextMeshProUGUI clickPerSecondText;
    private float time = 0;
    private int deltaClicks = 0;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogWarning("Morethan tone ui manager detected");
            Destroy(Instance);
        }
    }
    public void UpdateClicks(int Clicks)
    {
        clickText.text = Clicks.ToString();
        deltaClicks++;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 1)
        {
            clickPerSecondText.text = deltaClicks + "/s";

            deltaClicks = 0;
            time = 0;
        }
    }
}

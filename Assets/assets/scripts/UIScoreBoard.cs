using TMPro;
using UnityEngine;

public class UIScoreBoard : MonoBehaviour
{

    [SerializeField] private TMP_Text scoreField;
    [SerializeField] private TMP_Text multipierField;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ComboSystem.OnScoreChange += HandleScoreChange;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void HandleScoreChange(int score, int multiplier)
    {
        scoreField.text = "Score: " + score;
        multipierField.text = "Multiplier: " + multiplier + "X";
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    void Update()
    {
        scoreText.text = "Score: " + GameManager.Instance.Score;
    }
}

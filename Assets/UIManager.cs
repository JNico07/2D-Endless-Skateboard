using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    GameManager gameManager;
    [SerializeField] private TextMeshProUGUI scoreUI;
    
    private void Start() {
        gameManager = GameManager.Instance;
    }

    private void OnGUI() {
        scoreUI.text = gameManager.PrettyScore;
    }
}

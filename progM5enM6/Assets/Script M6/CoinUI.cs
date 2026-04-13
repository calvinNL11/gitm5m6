using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class coinUI : MonoBehaviour
{
    private int _points = 0;
    private TextMeshProUGUI _scoreText;

    void Start()
    {
        Coin.CoinCollected += OnCollect;
        _scoreText = GetComponent<TextMeshProUGUI>();
    }
    void OnDisable()
    {
        Coin.CoinCollected -= OnCollect;

    }
    void OnCollect(int score)
    {
        _points += score;
        _scoreText.text = "Score: " + _points + "     " + score;
    }
}


/* Gun'em Down
 * GameController.cs
 * Created by Mauro J. Pappaterra on 10 of July 2017.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    // Score text
    public GUIText ScoreText;
    public int score = 0;

    // Ammo text
    public GUIText AmmoText;

    // Game Over
    public GUIText endText;
    public bool gameEnded;

    public void Start()
    {
        gameEnded = false;
        endText.gameObject.SetActive(false);
        ScoreText.text = "Kills 0";

        UpdateAmmo(20);
    }

    public void Update()
    {
        if (gameEnded)
        {
            if (Input.GetKeyDown (KeyCode.R))
            {
                Scene level = SceneManager.GetActiveScene();
                SceneManager.LoadScene(level.name);

            }

        }
    }

    public void AddScore()
    {
        score++;
        ScoreText.text = "Kills " + score;
    }

    public void EndGame()
    {
        gameEnded = true;
        endText.gameObject.SetActive(true);
    }

    public void UpdateAmmo(float n)
    {
        AmmoText.text = "Ammo " + n;
    }
}

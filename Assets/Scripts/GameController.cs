using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    #region public stuff
    public GameObject hazard;
    public Vector2 spawnValue;
    public int hazardCount;
    public float spawnTem;
    public float startTem;
    public float waveTem;
    public TextMesh textScore;
    public TextMesh textGO;
    public TextMesh textRestart;
    #endregion

    #region private stuff
    private int score;
    private bool gameOver = false;
    private bool restart;
    #endregion



    // Use this for initialization
    void Start () {
        gameOver = false;
        score = 0;

        UpdateScore();
        textGO.text = "";
        textRestart.text = "";

        StartCoroutine(SpawnWaves());
	}
	
	// Update is called once per frame
	void Update () {
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                //Application.LoadLevel(Application.loadedLevel);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Application.LoadLevel(Application.loadedLevel);
            Application.Quit();
        }
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startTem);
        while (true)
        {
            for(int i = 0; i < hazardCount; i++)
            {
                Vector2 spawnPos = new Vector2(spawnValue.x, Random.Range(-spawnValue.y, spawnValue.y));
                Quaternion spawnRot = Quaternion.identity;
                Instantiate(hazard, spawnPos, spawnRot);
                yield return new WaitForSeconds(spawnTem);
            }
            yield return new WaitForSeconds(waveTem);

            hazardCount++;
            spawnTem *= 0.9f;

            if(gameOver == true)
            {
                break;
            }
            
        }
    }

    void UpdateScore()
    {
        textScore.text = ("Score\n*" + score + "*");
    }

    public void GameOver()
    {
        gameOver = true;
        textGO.text = "GAME OVER";
        textRestart.text = "Press 'R' to restart, scrub.";
        restart = true;
    }

    public void AddScore(int addVal)
    {
        score += addVal;
        UpdateScore();
    }
}

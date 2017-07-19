using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    #region public stuff
    public GameObject hazard;
    public Vector2 spawnValue;
    public int hazardCount;
    public float spawnTem;
    public float startTem;
    public float waveTem;
    #endregion

    #region private stuff
    private int score;
    private bool gameOver = false;
    #endregion



    // Use this for initialization
    void Start () {
        gameOver = false;
        score = 0;

        StartCoroutine(SpawnWaves());
	}
	
	// Update is called once per frame
	void Update () {
		
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

    }

    public void GameOver()
    {
        gameOver = true;
    }

    public void AddScore(int addVal)
    {
        score += addVal;
        UpdateScore();
        Debug.Log(score);
    }
}

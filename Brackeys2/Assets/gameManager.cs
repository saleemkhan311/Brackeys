using UnityEngine;


public class gameManager : MonoBehaviour
{
    public bool gameHasEnded = false;
    public GameObject gameOverCanvas;
    public float restartDelay = 2f;
    public bool levelcmplt = false;
    public GameObject lvlCompleteCanvas;

    public void levelComplete()
    {
        lvlCompleteCanvas.SetActive(true);
        levelcmplt = true;
        Debug.Log("LEVEL CMPLT!");

    }

   public void endGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER!");
            Invoke("Restart", restartDelay);
        }
    }

    public void Restart()
    {
        if(levelcmplt == false)
         gameOverCanvas.SetActive(true);
        
    }
}

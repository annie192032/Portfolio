using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    //public Text roundsText;

    void OnEnable()
    {
        //roundsText.text = PlayerStats.Rounds.ToString();
    }
    public void Retry()
    {
        SceneManager.LoadScene(0);
    }
}

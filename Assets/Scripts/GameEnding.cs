
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

/* this script will be used to toggle 
the alpha property of the ExitImageBackground 
when the player passes through the
GameEndingTrigger and that the script is a
component of the GameEndingTrigger 
Jacob Wickwire
5/31/2024 
*/
public class GameEnding : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private CanvasGroup exitBackgroundImageCanvasGroup;
    [SerializeField] private CanvasGroup caughtBackgroundImageCanvasGroup;
    [SerializeField] AudioSource exitAudio;
    [SerializeField] AudioSource caughtAudio;
    bool hasAudioPlayed; 

    float fadeDuration;
    float displayImageDuration;
    float timer;
    bool isPlayerAtExit;
    bool isPlayerCaught;
    bool restart;

    // Start is called before the first frame update
    void Start()
    {
        fadeDuration = 1.0f;
        displayImageDuration = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isPlayerAtExit)
        {
            EndLevel(exitBackgroundImageCanvasGroup, false, exitAudio);
        }
        else if (isPlayerCaught)
        {
            EndLevel(caughtBackgroundImageCanvasGroup, true, caughtAudio);
        }
        
    }

    private void EndLevel(CanvasGroup image, bool restartGame, AudioSource audioSource)
    {
        if (!hasAudioPlayed)
        {
            audioSource.Play();
            hasAudioPlayed = true;
        }


        timer += Time.deltaTime;

        image.alpha = timer / fadeDuration;

        if (timer > fadeDuration + displayImageDuration)
        {
            if (restart == true)
            {
                SceneManager.LoadScene(0); 
            }
            else
            {
                Application.Quit(); 
            }


        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            isPlayerAtExit = true;
        }

    }

    public void CaughtPlayer()
    {
        isPlayerCaught = true;
        restart = true; 
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    float fadeDuration;
    float displayImageDuration;
    float timer;
    bool isPlayerAtExit; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

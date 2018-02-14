using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    bool Active;
    public Text HS;
    public Text score;
    int maxcount = Diff.max_count;
    [SerializeField]
    Text countdown;
    int remain;
    string diff = Diff.difficult;
    string exit = "It's the end, the number was: ";
    string highscore;
    [SerializeField]
    private GameObject window;
    [SerializeField]
    Text lives;
    [SerializeField]
    Text txt;
    int counts;
    int hscore;
    private int rnd;
    [SerializeField]
    private InputField input;
    [SerializeField]
    private Text text;
    void Start()
    {
        StartCoroutine(StartCoutdown());
        if (diff == "Easy")
        {
            rnd = Random.Range(1, 11);
            text.text = "Guess the number between 1 and 10";
        }
        else if (diff == "Average")
        {
            text.text = "Guess the number between 1 and 50";
            rnd = Random.Range(1, 51);
        }
        else
        {       rnd = Random.Range(1, 101);
        text.text = "Guess the number between 1 and 100";
    }
        
    }
    
    void Awake()
    {
       // rnd = Random.Range(1, 11);

        window.SetActive(false);
        //Debug.Log(maxcount);
        //Debug.Log(counts);

        // input = GameObject.Find("InputField").GetComponent<InputField>();
        //text.text = "Guess the number between 1 and 10";

        //  GetInput();
    }
   public void Exit()
    {
        Application.Quit();

    }

    public void GetInput(string guess)
{
       
        Debug.Log(rnd);
        CompGuesses(int.Parse(guess));
        //Debug.Log(guess);
        input.text = "";

}
    
    float currCountdown;
    public IEnumerator StartCoutdown(float currcountdown = 30)
    {
        currCountdown = Diff.seconds;
        while (currCountdown > 0)
        {
           // Debug.Log("Countdown" + currCountdown);
            yield return new WaitForSeconds(1.0f);
            currCountdown--;
        }
        if (currCountdown < 1) {
            StopCoroutine(StartCoutdown());
            
            Show();
            
            
        }
       
    }


    void CompGuesses(int guess)
    {
        //
        if (guess == rnd)
        {
            hscore = (int)(currCountdown * Diff.multiplier) + (remain * Diff.multiplier_counts);
            text.text = "You won, the number was " + guess;
            if (PlayerPrefs.GetInt("Highscore") < hscore)
            { PlayerPrefs.SetInt("Highscore", hscore) ; }
            Show();
            currCountdown = 0;
        }
        else if (guess < rnd)
        {
            
            text.text = "your number is too low";
        }
        else if (guess > rnd)
        {
            text.text = "your number is too high";
        }
        counts++;
        lives.text = "You have " + remain.ToString() + " more chance.";
    }
    void Show()
    {

        HS.text ="Your Highscore is: "+ (PlayerPrefs.GetInt("Highscore")).ToString();
        score.text = "Your current score is : " + hscore;
        txt.text = exit + rnd;
        window.SetActive(true);
        Active = true;

    }
    void Hide() {
        window.SetActive(false);
        Active = false;
    }
   private void Update()
    {
        if (Active)
        {
            StopCoroutine(StartCoutdown());
        }
        
        countdown.text = "Countdown: " + currCountdown;
        remain = maxcount - counts;
        if (maxcount < counts)
        {
            hscore = (int)(currCountdown * Diff.multiplier) + (remain * Diff.multiplier_counts);
            Show();
            //highscore =counts.ToString();
            //PlayerPrefs.SetInt("Highscore",counts);   
            StopCoroutine(StartCoutdown());
            countdown.text = "0";
        }
       
   

    }



 
}

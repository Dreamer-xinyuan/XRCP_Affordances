using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// we are going to think abstractly about this
// as many of you won't be making a game
// what would be the states of your experience?
public enum State
{
    Beginning,
    Middle,
    End,
    Backroom0,
    Backroom1,
    Backroom11,
    Backroom2,
    Backroom4,
    Backroom5,
    Backroom6,
    Backroom7,
    W0,
    W1,
    W2,
    W3,
    W4,
    W5,
    W6,
    W7,
    B1,
    B2,
    F0



}

public class GameManager : MonoBehaviour
{

    //Singleton pattern
    //The static keyword is our clue here that we are 
    //creating a globally available variable 
    public static GameManager Instance { get; private set; }

    public State experienceState;

    private VRCPSceneLoader sceneLoader;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this; // if this is the first Instance set our static variable to this one 
            DontDestroyOnLoad(Instance);
            SceneManager.sceneLoaded += OnSceneLoaded;
            Debug.Log("First Game Manager Made!");
        }
        else
        {
            Destroy(gameObject); // if our Instance variable has already been set destroy any new ones
            Debug.Log("Darn a Game Manager beat me to it!");
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {

        VRCPSceneLoader[] loaders = GameObject.FindObjectsOfType<VRCPSceneLoader>();

        if (loaders.Length == 1)
        {
            sceneLoader = loaders[0];
        }
        else
        {
            Debug.Log("Error: you have " + loaders.Length + " scene loaders in the scene, you should have 1");
        }

    }

    public void UpdateState(State newState)
    {
        experienceState = newState;

        switch (experienceState)
        {
            case State.Beginning:
                HandleBeginning();
                break;
            case State.Middle:
                HandleMiddle();
                break;
            case State.End:
                //do something else
                HandleEnd();
                break;
            case State.Backroom0:
                //do something else
                HandleBackroom0();
                break;
            case State.Backroom1:
                //do something else
                HandleBackroom1();
                break;
            case State.Backroom11:
                //do something else
                HandleBackroom11();
                break;    
            case State.Backroom2:
                //do something else
                HandleBackroom2();
                break;
            case State.Backroom4:
                //do something else
                HandleBackroom4();
                break;
            case State.Backroom5:
                //do something else
                HandleBackroom5();
                break;
            case State.Backroom6:
                //do something else
                HandleBackroom6();
                break;
            case State.Backroom7:
                //do something else
                HandleBackroom7();
                break;
            case State.W0:
                //do something else
                HandleW0();
                break;
            case State.W1:
                //do something else
                HandleW1();
                break;
            case State.W2:
                //do something else
                HandleW2();
                break;
            case State.W3:
                //do something else
                HandleW3();
                break;
            case State.B1:
                //do something else
                HandleB1();
                break;
            case State.B2:
                //do something else
                HandleB2();
                break;
            case State.F0:
                //do something else
                HandleF0();
                break;
        }

    }

    //Welcome moment
    private void HandleBeginning()
    {
        //Maybe there's something specific you need to do in code here.
        sceneLoader.GoToSceneAsync("0_StoryExampleScene");
    }

    private void HandleMiddle()
    {
        //Maybe there's something specific you need to do in code here.
        sceneLoader.GoToSceneAsync("1_StoryExampleScene");
    }

    private void HandleEnd()
    {
        //Maybe there's something specific you need to do in code here.
        sceneLoader.GoToSceneAsync("ExampleTeamMateScene");
    }
    private void HandleBackroom0()
    {
        //Maybe there's something specific you need to do in code here.
        sceneLoader.GoToSceneAsync("0_backroom");
    }

    private void HandleBackroom1()
    {
        //Maybe there's something specific you need to do in code here.
        sceneLoader.GoToSceneAsync("1_backroom 1");
    }
    private void HandleBackroom11()
    {
        //Maybe there's something specific you need to do in code here.
        sceneLoader.GoToSceneAsync("1.5_backroom");
    }
    private void HandleBackroom2()
    {
        //Maybe there's something specific you need to do in code here.
        sceneLoader.GoToSceneAsync("2_backroom2");
    }
    private void HandleBackroom4()
    {
        //Maybe there's something specific you need to do in code here.
        sceneLoader.GoToSceneAsync("4_backroom1 1");
    }
    private void HandleBackroom5()
    {
        //Maybe there's something specific you need to do in code here.
        sceneLoader.GoToSceneAsync("5_backroom1 2");
    }
    private void HandleBackroom6()
    {
        //Maybe there's something specific you need to do in code here.
        sceneLoader.GoToSceneAsync("6_backroom1 3");
    }
    private void HandleBackroom7()
    {
        //Maybe there's something specific you need to do in code here.
        sceneLoader.GoToSceneAsync("7_backroom1 3");
    }
    private void HandleW0()
    {
        //Maybe there's something specific you need to do in code here.
        sceneLoader.GoToSceneAsync("0_Wonderland");
    }
    private void HandleW1()
    {
        //Maybe there's something specific you need to do in code here.
        sceneLoader.GoToSceneAsync("1_Wonderland");
    }
    private void HandleW2()
    {
        //Maybe there's something specific you need to do in code here.
        sceneLoader.GoToSceneAsync("2_Wonderland");
    }
    private void HandleW3()
    {
        //Maybe there's something specific you need to do in code here.
        sceneLoader.GoToSceneAsync("3_Wonderland");
    }
    private void HandleB1()
    {
        //Maybe there's something specific you need to do in code here.
        sceneLoader.GoToSceneAsync("Bedroom");
    }
    private void HandleB2()
    {
        //Maybe there's something specific you need to do in code here.
        sceneLoader.GoToSceneAsync("Bedroom 1");
    }
    private void HandleF0()
    {
        //Maybe there's something specific you need to do in code here.
        sceneLoader.GoToSceneAsync("Final");
    }





    // Update is called once per frame
    void Update()
    {
        
    }
}

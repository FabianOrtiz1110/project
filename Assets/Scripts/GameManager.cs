using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	private bool isGameOver = false;
	private float elapsedTime = 0;
	private bool isRunning = true;	
    string Battery;

	private void StartGame()
	{
		elapsedTime = 0;
		isRunning = true;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
    void Update ()
	{

        if (elapsedTime == -900)
        {
            isGameOver = true;
        }

		if (isRunning)
		{
			elapsedTime = elapsedTime - Time.deltaTime;
		}
	}		
	public static GameManager instance = null;
		void Awake()
		{
			if (instance == null)
			instance = this;
			else if (instance != null)
			 	Destroy (gameObject);
		}

	public void Win()
	{

		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void OnGUI()
	{
		if(isGameOver) {
			Rect rect = new Rect (Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
			GUI.Box (rect, "Your Battery is out");
			isRunning = false;

			string message; 
			{
				message = "Press Enter to Play Again";
			}

			//Define a new rectangle for the UI on the screen
			Rect startButton = new Rect(Screen.width/2 - 120, Screen.height/2 + 50, 240, 40);

			if (GUI.Button(startButton, message) || Input.GetKeyDown(KeyCode.Return))
			{
				//start the game if the user clicks to play
				StartGame ();
			}

		}
		else if(isRunning)
		{ 
			// If the game is running, show the current time
            if (elapsedTime < -1)
                {
                    Battery = ("Full");
                }

            if (elapsedTime < -450)
                {
                    Battery = ("Half");
                }
            if (elapsedTime < -840)
                {
                    Battery = ("Almost Empty");
                }

			GUI.Box(new Rect(Screen.width / 2 - 65, Screen.height - 115, 130, 40), "Your Battery is");
			GUI.Label(new Rect(Screen.width / 2 - 10, Screen.height - 100, 40, 30),  (Battery));
		}
	}
}
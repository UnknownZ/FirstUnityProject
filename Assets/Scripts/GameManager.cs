using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ViewWelcome ViewWelcome = null;
    [SerializeField] private ViewGameplay ViewGameplay = null;

    [SerializeField] private AudioSource audiosource = null;
    [SerializeField] private AudioClip sfxButton = null;
    [SerializeField] private AudioClip sfxWin = null;
    [SerializeField] private AudioClip sfxLose = null;


    private GameGrid grid;
    private GameController controller;

    private void Awake()
    {
        grid = new GameGrid();

    }

    private void Start()
    {
        GoToHome();
    }

    private void OnEnable()
    {
        ViewWelcome.OnButtonPlayClicked += OnButtonPlayClickedHandler;
        ViewWelcome.OnButtonQuitClicked += OnButtonQuitClickedHandler;

        ViewGameplay.OnButtonQuitClicked += OnButtonQuitGameClickedHandler;
        ViewGameplay.OnButtonTileClicked += OnButtonTileClickedHandler;
    }

    private void OnDisable()
    {
        ViewWelcome.OnButtonPlayClicked -= OnButtonPlayClickedHandler;
        ViewWelcome.OnButtonQuitClicked -= OnButtonQuitClickedHandler;

        ViewGameplay.OnButtonQuitClicked -= OnButtonQuitGameClickedHandler;
        ViewGameplay.OnButtonTileClicked -= OnButtonTileClickedHandler;
    }

    private void OnButtonPlayClickedHandler()
    {
        PlaySfxButton();
        GoToGame();
    }

    private void OnButtonQuitClickedHandler()
    {
        PlaySfxButton();
        print("Quit");
    }

    private void OnButtonTileClickedHandler(int index)
    {
        print($"Clicked tile: {index}");
    }

    private void OnButtonQuitGameClickedHandler()
    {
        PlaySfxButton();
        GoToHome();
    }

    public void GoToHome()
    {
        ViewWelcome.gameObject.SetActive(true);
        ViewGameplay.gameObject.SetActive(false);
    }

    public void GoToGame()
    {
        ViewGameplay.gameObject.SetActive(true);
        ViewWelcome.gameObject.SetActive(false);

        ViewGameplay.ClearGrid();
    }

    private void PlaySfxButton()
    {
        audiosource.PlayOneShot(sfxButton);
    }
}

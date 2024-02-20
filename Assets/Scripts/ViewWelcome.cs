using UnityEngine;
using UnityEngine.UI;
using System;

public class ViewWelcome : MonoBehaviour
{
    public event Action OnButtonPlayClicked;
    public event Action OnButtonQuitClicked;

    [SerializeField] private Button buttonPlay = null;
    [SerializeField] private Button buttonQuit = null;

    private void OnDisable()
    {
        buttonPlay.onClick.RemoveAllListeners();
        buttonQuit.onClick.RemoveAllListeners();

    }

    private void OnEnable()
    {
        buttonPlay.onClick.AddListener(ButtonPlayClickHandler);
        buttonQuit.onClick.AddListener(ButtonQuitClickHandler);

    }

    private void ButtonPlayClickHandler()
    {
        OnButtonPlayClicked?.Invoke();
    }

    private void ButtonQuitClickHandler()
    {
        OnButtonQuitClicked?.Invoke();
    }
}

using System;
using UnityEngine;
using UnityEngine.UI;

public class ViewGameplay : MonoBehaviour
{
   public event Action OnButtonQuitClicked;
   public event Action<int> OnButtonTileClicked;

    [SerializeField] private Button ButtonQuit = null;
    [SerializeField] private Button[] tiles;



   public void ClearGrid()
   {

   }
   
   public void PlayTile(int index)
   {

   }

   private void OnEnable()
   {
    ButtonQuit.onClick.AddListener(ButtonQuitHandler);
   }

   private void OnDisable()
   {
    ButtonQuit.onClick.RemoveAllListeners();
   }
   private void ButtonQuitHandler()
   {
    OnButtonQuitClicked?.Invoke();
   }

   private void TileCLickHandler(int index)
   {
        OnButtonTileClicked?.Invoke(index);
   }
   }

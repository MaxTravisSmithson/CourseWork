using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu, _menu;
    [SerializeField] private TextMeshProUGUI _menuManager;

    //This will subscribe to the object
    private void Awake()
    {
        GameManager.OnGameStateChanged += GameManagerOnOnGameStateChanged;
    }

    //This will make sure we unsubscribe when we need to to avoid errors
    private void OnDestroy()
    {
        GameManager.OnGameStateChanged -= GameManagerOnOnGameStateChanged;
    }

    private void GameManagerOnOnGameStateChanged(GameState state)
    {
        _mainMenu.SetActive(state == GameState.Menu);
    }

    private void Start()
    {
        
    }
}

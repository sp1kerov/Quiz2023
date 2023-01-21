using UnityEngine;

public class PanelMenu : Panel 
{
    [SerializeField] private PanelController _panelController;

    public void StartGame() // метод запуска игры для кнопки Старт
    {
        _panelController.OnGame();
    }

    public void GoStting() // метод запуска игры для кнопки Старт
    {
        _panelController.OnSetting();
    }

    public void QuitGame() // метод выхода из игры для книпки Выход
    {
        Application.Quit();
    }
}
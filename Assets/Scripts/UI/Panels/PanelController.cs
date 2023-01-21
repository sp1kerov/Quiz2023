using UnityEngine;

public class PanelController : MonoBehaviour
{
    [SerializeField] private PanelMenu _panelMenu; // панель меню
    [SerializeField] private PanelGame _panelGame; // панель игры
    [SerializeField] private PanelWin _panelWin; // панель победы
    [SerializeField] private PanelSetting _panelSetting; // панель победы
    [SerializeField] private PanelGameOver _panelGameOver; // панель проигрыша

    private void Start()
    {
        OffPanels();
        _panelMenu.gameObject.SetActive(true);
    }

    public void OnMenu() // всключение панели меню
    {
        PanelActivator(_panelMenu);
    }

    public void OnGame() // всключение панели игры
    {
        PanelActivator(_panelGame);
    }
    
    public void WinGame() // всключение панели победы
    {
        PanelActivator(_panelWin);
    }

    public void OnSetting() // всключение панели настроек
    {
        PanelActivator(_panelSetting);
    }

    public void OnGameOver() // всключение панели проигрыша
    {
        PanelActivator(_panelGameOver); 
    }

    private void OffPanels() // метод выключения панелей
    {
        _panelMenu.gameObject.SetActive(false);
        _panelGame.gameObject.SetActive(false);
        _panelWin.gameObject.SetActive(false);
        _panelSetting.gameObject.SetActive(false);
        _panelGameOver.gameObject.SetActive(false);
    }

    private void PanelActivator(Panel panel)
    {
        OffPanels(); // выключаем все панели
        panel.gameObject.SetActive(true); // включаем нужную
    }
}

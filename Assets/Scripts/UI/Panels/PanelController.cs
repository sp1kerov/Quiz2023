using UnityEngine;

public class PanelController : MonoBehaviour
{
    [SerializeField] private PanelMenu _panelMenu; // ������ ����
    [SerializeField] private PanelGame _panelGame; // ������ ����
    [SerializeField] private PanelWin _panelWin; // ������ ������
    [SerializeField] private PanelSetting _panelSetting; // ������ ������
    [SerializeField] private PanelGameOver _panelGameOver; // ������ ���������

    private void Start()
    {
        OffPanels();
        _panelMenu.gameObject.SetActive(true);
    }

    public void OnMenu() // ���������� ������ ����
    {
        PanelActivator(_panelMenu);
    }

    public void OnGame() // ���������� ������ ����
    {
        PanelActivator(_panelGame);
    }
    
    public void WinGame() // ���������� ������ ������
    {
        PanelActivator(_panelWin);
    }

    public void OnSetting() // ���������� ������ ��������
    {
        PanelActivator(_panelSetting);
    }

    public void OnGameOver() // ���������� ������ ���������
    {
        PanelActivator(_panelGameOver); 
    }

    private void OffPanels() // ����� ���������� �������
    {
        _panelMenu.gameObject.SetActive(false);
        _panelGame.gameObject.SetActive(false);
        _panelWin.gameObject.SetActive(false);
        _panelSetting.gameObject.SetActive(false);
        _panelGameOver.gameObject.SetActive(false);
    }

    private void PanelActivator(Panel panel)
    {
        OffPanels(); // ��������� ��� ������
        panel.gameObject.SetActive(true); // �������� ������
    }
}

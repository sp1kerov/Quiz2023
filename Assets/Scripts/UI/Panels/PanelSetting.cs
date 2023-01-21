using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSetting : Panel
{
    [SerializeField] private PanelController _panelController;

    public void GoMenu()
    {
        _panelController.OnMenu();
    }
}

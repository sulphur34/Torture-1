
using UnityEngine;

public class InGameMenu : Menu
{
    [SerializeField] private DefenceState _defenceState;
    [SerializeField] private BuildState _buildState;
    [SerializeField] private TurretsAmountLabel _turretsAmountLabel;
    [SerializeField] private BuildingTimerLabel _buildingTimerLabel;


    private void OnEnable()
    {
        _buildState.Entered += Open;
        _defenceState.Exited += Close;
    }

    private void OnDisable()
    {
        _buildState.Entered -= Open;
        _defenceState.Exited -= Close;
    }

    public override void Open()
    {
        base.Open();
        _turretsAmountLabel.gameObject.SetActive(true);
        _buildingTimerLabel.gameObject.SetActive(true);
    }
}
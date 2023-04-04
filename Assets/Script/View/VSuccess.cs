using UnityEngine;
using UnityEngine.UI;

public class VSuccess : MonoBehaviour
{
	public Text NameLable;

	private Success m_Success;

	public void SetInfo(int id)
	{
		m_Success = DataManager.Instance.GetSuccessList()[id];
		ResetShow();
	}

	private void ResetShow()
	{
		NameLable.text = m_Success.Name;
	}
}

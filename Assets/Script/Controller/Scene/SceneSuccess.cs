using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneSuccess : MonoBehaviour
{
	public GameObject SuccessPrefeb;

	public GridLayoutGroup ToggleGroupObj;

	public Image Hint;

	public Image Depot;

	public Text SuccessText;

	private List<int> m_SuccessList = new List<int>();

	private Dictionary<int, VSuccess> m_LoadSuccess = new Dictionary<int, VSuccess>();

	private void Start()
	{
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_ReachSuccess, ReachSuccess);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_OpenSuccess, OpenSuccess);
		Close();
	}

	private void OpenSuccess(object prame)
	{
		List<Success> successList = DataManager.Instance.GetSuccessList();
		for (int i = 0; i < successList.Count; i++)
		{
			if (successList[i].Schedule >= successList[i].Target && !m_LoadSuccess.ContainsKey(i))
			{
				GameObject gameObject = Object.Instantiate(SuccessPrefeb, ToggleGroupObj.transform);
				VSuccess component = gameObject.GetComponent<VSuccess>();
				component.SetInfo(i);
				m_LoadSuccess.Add(i, component);
			}
		}
		Depot.gameObject.SetActive(value: true);
	}

	public void CloseSuccess()
	{
		Depot.gameObject.SetActive(value: false);
	}

	private void ShowOneSuccess()
	{
		if (!Hint.gameObject.activeSelf && m_SuccessList.Count > 0)
		{
			int index = m_SuccessList[0];
			m_SuccessList.RemoveAt(0);
			SuccessText.text = "成就：\"" + DataManager.Instance.GetSuccessList()[index].Name + "\"达成!";
			Hint.gameObject.SetActive(value: true);
			TimeManager.Instance.SetTimer(2f, delegate
			{
				Hint.gameObject.SetActive(value: false);
				ShowOneSuccess();
			});
		}
	}

	private void ReachSuccess(object prame)
	{
		MsgDefine.MsgPrame_ReachSuccess msgPrame_ReachSuccess = (MsgDefine.MsgPrame_ReachSuccess)prame;
		m_SuccessList.Add(msgPrame_ReachSuccess.ID);
		ShowOneSuccess();
	}

	private void Close()
	{
		Hint.gameObject.SetActive(value: false);
		Depot.gameObject.SetActive(value: false);
	}

	private void Update()
	{
	}
}

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SceneShop : MonoBehaviour
{
	public GameObject ItemPrefeb;

	public ToggleGroup ToggleGroupObj;

	public Text Describe;

	public Text State;

	public Text Money;

	public Button BuyBtn;

	private int m_BuyId = -1;

	private List<VGoods> m_GoodsInfo = new List<VGoods>();

	private void Start()
	{
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_ShowShop, ShowShop);
		base.gameObject.SetActive(value: false);
	}

	public void OnClickBuy()
	{
		Item item = GameDataBase.Instance.GetItem(m_BuyId);
		DataManager.Instance.SetSuccess(2, DataManager.Instance.GetSchedule(2) + item.Expend);
		GameDataBase.Instance.NowMoney -= item.Expend;
		Money.text = GameDataBase.Instance.NowMoney.ToString();
		GameDataBase.Instance.AddItem(m_BuyId, 1);
		State.text = "当前拥有 : " + GameDataBase.Instance.GetItemCount(m_BuyId);
		if (item.Expend > GameDataBase.Instance.NowMoney)
		{
			BuyBtn.interactable = false;
		}
		else
		{
			BuyBtn.interactable = true;
		}
	}

	public void CloseShop()
	{
		foreach (VGoods item in m_GoodsInfo)
		{
			Object.Destroy(item.gameObject);
		}
		m_GoodsInfo.Clear();
		base.gameObject.SetActive(value: false);
		MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseShop));
	}

	private void ShowShop(object prame)
	{
		MsgDefine.MsgPrame_ShowShop msgPrame_ShowShop = (MsgDefine.MsgPrame_ShowShop)prame;
		if (msgPrame_ShowShop.GoodsID.Count <= 0)
		{
			return;
		}
		ClearShowText();
		Money.text = GameDataBase.Instance.NowMoney.ToString();
		foreach (int id in msgPrame_ShowShop.GoodsID)
		{
			GameObject gameObject = Object.Instantiate(ItemPrefeb, ToggleGroupObj.transform);
			VGoods component = gameObject.GetComponent<VGoods>();
			component.SetInfo(id);
			Toggle component2 = gameObject.GetComponent<Toggle>();
			component2.group = ToggleGroupObj;
			UnityAction<bool> call = delegate(bool arg)
			{
				if (!arg)
				{
					ClearShowText();
				}
				else
				{
					ShowText(id);
				}
			};
			component2.onValueChanged.AddListener(call);
			m_GoodsInfo.Add(component);
		}
		base.gameObject.SetActive(value: true);
	}

	private void ClearShowText()
	{
		m_BuyId = -1;
		Describe.text = string.Empty;
		State.text = string.Empty;
	}

	private void ShowText(int id)
	{
		m_BuyId = id;
		Item item = GameDataBase.Instance.GetItem(m_BuyId);
		Describe.text = item.Describe + "\n价格 : " + item.Expend;
		State.text = "当前拥有 : " + GameDataBase.Instance.GetItemCount(m_BuyId);
		if (item.Expend > GameDataBase.Instance.NowMoney)
		{
			BuyBtn.interactable = false;
		}
		else
		{
			BuyBtn.interactable = true;
		}
	}

	private void Update()
	{
	}
}

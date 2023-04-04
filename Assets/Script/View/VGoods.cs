using UnityEngine;
using UnityEngine.UI;

public class VGoods : MonoBehaviour
{
	public Text NameLable;

	private Item m_Item;

	public void SetInfo(int id)
	{
		m_Item = GameDataBase.Instance.GetItem(id);
		ResetShow();
	}

	private void ResetShow()
	{
		NameLable.text = m_Item.Name;
	}
}

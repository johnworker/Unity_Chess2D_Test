using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class VTerrain : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	private int m_X;

	private int m_Y;

	private Image m_Image;

	private Terrain m_Terrain;

	private int m_FighterID = -1;

	public Terrain.TerrainType TerrainType => m_Terrain.Type;

	public Vector3 Position => m_Image.rectTransform.localPosition;

	public int FighterID => m_FighterID;

	public int X => m_X;

	public int Y => m_Y;

	public void Init(int x, int y, Terrain terrain, Vector3 pos)
	{
		m_X = x;
		m_Y = y;
		m_Image = base.gameObject.AddComponent<Image>();
		m_Terrain = terrain;
		m_Image.rectTransform.sizeDelta = new Vector2(Define.MapElementWidth, Define.MapElementWidth);
		m_Image.rectTransform.pivot = new Vector2(0.5f, 0.5f);
		m_Image.rectTransform.localScale = new Vector3(1f, 1f, 1f);
		m_Image.rectTransform.localPosition = pos;
		m_Image.sprite = DataManager.Instance.MapElementSprite[m_Terrain.Icon];
	}

	public void Carry(int id)
	{
		m_FighterID = id;
	}

	public void TakeOff()
	{
		m_FighterID = -1;
	}

	public bool CanMove()
	{
		return m_Terrain.CanMove;
	}

	public void SetBlack(bool black)
	{
		if (black)
		{
			m_Image.material = DataManager.Instance.BlackAndWrite;
		}
		else
		{
			m_Image.material = null;
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		if (m_Terrain != null)
		{
			MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ClickTerrain(m_Terrain, m_X, m_Y));
		}
	}
}

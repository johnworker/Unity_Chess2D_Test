using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VDamage : MonoBehaviour
{
	private GameObject m_GridObj;

	private GridLayoutGroup m_Grid;

	private List<Image> m_DamageBase = new List<Image>();

	private List<Image> m_DamageList = new List<Image>();

	private List<float> m_DamageFrameTime = new List<float>();

	private List<int> m_DamageFrame = new List<int>();

	private float[] m_DamagePositinY = new float[14]
	{
		8f, 20f, 35f, 41f, 42f, 40f, 20f, 10f, 0f, -10f,
		-18f, -9f, -5f, 0f
	};

	public void Close()
	{
		foreach (Image item in m_DamageBase)
		{
			item.gameObject.SetActive(value: false);
		}
		base.enabled = false;
	}

	public void Show(int damage)
	{
		base.enabled = true;
		foreach (Image item in m_DamageBase)
		{
			item.gameObject.SetActive(value: false);
		}
		int num = damage;
		if (num == 0)
		{
			if (1 > m_DamageBase.Count)
			{
				GameObject gameObject = new GameObject("Base");
				gameObject.transform.SetParent(m_GridObj.transform);
				Canvas canvas = gameObject.AddComponent<Canvas>();
				canvas.sortingOrder = 1;
				canvas.overrideSorting = true;
				Image image = gameObject.AddComponent<Image>();
				image.transform.localScale = new Vector3(1f, 1f, 1f);
				image.sprite = DataManager.Instance.DamageBase;
				m_DamageBase.Add(image);
				GameObject gameObject2 = new GameObject("Num");
				gameObject2.transform.SetParent(gameObject.transform);
				canvas = gameObject2.AddComponent<Canvas>();
				canvas.sortingOrder = 2;
				canvas.overrideSorting = true;
				Image image2 = gameObject2.AddComponent<Image>();
				image2.rectTransform.pivot = new Vector2(0.5f, 0f);
				image2.rectTransform.sizeDelta = new Vector2(Define.MapElementWidth / 3f, Define.MapElementWidth / 2f);
				image2.rectTransform.localScale = new Vector3(1f, 1f, 1f);
				m_DamageList.Add(image2);
				m_DamageFrame.Add(0);
				m_DamageFrameTime.Add(0f);
			}
			m_DamageFrame[0] = 0;
			m_DamageList[0].sprite = DataManager.Instance.DamageList[0];
			m_DamageBase[0].gameObject.SetActive(value: true);
			m_DamageList[0].gameObject.SetActive(value: false);
			return;
		}
		int num2 = 0;
		while (num > 0)
		{
			if (num2 + 1 > m_DamageBase.Count)
			{
				GameObject gameObject3 = new GameObject();
				gameObject3.transform.SetParent(m_GridObj.transform);
				Canvas canvas2 = gameObject3.AddComponent<Canvas>();
				canvas2.sortingOrder = 1;
				canvas2.overrideSorting = true;
				Image image3 = gameObject3.AddComponent<Image>();
				image3.transform.localScale = new Vector3(1f, 1f, 1f);
				image3.sprite = DataManager.Instance.DamageBase;
				m_DamageBase.Add(image3);
				GameObject gameObject4 = new GameObject();
				gameObject4.transform.SetParent(gameObject3.transform);
				canvas2 = gameObject4.AddComponent<Canvas>();
				canvas2.sortingOrder = 2;
				canvas2.overrideSorting = true;
				Image image4 = gameObject4.AddComponent<Image>();
				image4.rectTransform.pivot = new Vector2(0.5f, 0f);
				image4.rectTransform.localScale = new Vector3(1f, 1f, 1f);
				image4.rectTransform.sizeDelta = new Vector2(Define.MapElementWidth / 3f, Define.MapElementWidth / 2f);
				m_DamageList.Add(image4);
				m_DamageFrame.Add(0);
				m_DamageFrameTime.Add(0f);
			}
			int num3 = num % 10;
			num /= 10;
			m_DamageFrame[num2] = 0;
			m_DamageList[num2].sprite = DataManager.Instance.DamageList[num3];
			m_DamageBase[num2].gameObject.SetActive(value: true);
			m_DamageList[num2].gameObject.SetActive(value: false);
			num2++;
		}
	}

	private void Awake()
	{
		m_GridObj = new GameObject("Damage");
		m_GridObj.transform.SetParent(base.transform);
		m_GridObj.transform.localScale = new Vector3(1f, 1f, 1f);
		m_Grid = m_GridObj.AddComponent<GridLayoutGroup>();
	}

	private void Start()
	{
		m_Grid.cellSize = new Vector2(Define.MapElementWidth / 3f, Define.MapElementWidth / 2f);
		m_Grid.childAlignment = TextAnchor.UpperCenter;
		m_Grid.constraint = GridLayoutGroup.Constraint.FixedRowCount;
		m_Grid.startCorner = GridLayoutGroup.Corner.UpperRight;
		m_Grid.padding.top = (int)Define.MapElementWidth;
		m_Grid.constraintCount = 1;
		(m_Grid.transform as RectTransform).sizeDelta = new Vector2(Define.MapElementWidth, Define.MapElementWidth);
		(m_Grid.transform as RectTransform).localPosition = Vector2.zero;
	}

	private void Update()
	{
		for (int i = 0; i < m_DamageFrame.Count; i++)
		{
			if (m_DamageBase[i].gameObject.activeSelf && m_DamageFrame[i] >= 2)
			{
				if (m_DamageFrame[i] >= 2 && !m_DamageList[i].gameObject.activeSelf)
				{
					m_DamageList[i].gameObject.SetActive(value: true);
				}
				else if (m_DamageFrame[i] >= m_DamagePositinY.Length)
				{
					m_DamageList[i].rectTransform.anchoredPosition = new Vector2(m_DamageList[i].rectTransform.anchoredPosition.x, m_DamagePositinY[m_DamagePositinY.Length - 1]);
				}
				else
				{
					m_DamageList[i].rectTransform.anchoredPosition = new Vector2(m_DamageList[i].rectTransform.anchoredPosition.x, m_DamagePositinY[m_DamageFrame[i] - 2]);
				}
			}
		}
		float deltaTime = Time.deltaTime;
		float num = 0.02f;
		for (int j = 0; j < m_DamageFrame.Count; j++)
		{
			if (!m_DamageBase[j].gameObject.activeSelf)
			{
				continue;
			}
			if (j == 0)
			{
				m_DamageFrameTime[j] += deltaTime;
				while (m_DamageFrameTime[j] > num)
				{
					m_DamageFrame[j]++;
					m_DamageFrameTime[j] -= num;
				}
			}
			else if (m_DamageFrame[j - 1] > 2)
			{
				m_DamageFrameTime[j] += deltaTime;
				while (m_DamageFrameTime[j] > num)
				{
					m_DamageFrame[j]++;
					m_DamageFrameTime[j] -= num;
				}
			}
		}
	}
}

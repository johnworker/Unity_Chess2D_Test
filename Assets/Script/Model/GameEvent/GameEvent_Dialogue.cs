using UnityEngine;

public class GameEvent_Dialogue : GameEvent
{
	private int m_Hand;

	private string m_Name;

	private string m_Line;

	private Vector2 m_Pos;

	public int Hand => m_Hand;

	public string Name => m_Name;

	public string Line => m_Line;

	public Vector2 Pos => m_Pos;

	public GameEvent_Dialogue(string line, string name, int hand, Vector2 pos)
		: base(Define.EventType.Dialogue)
	{
		m_Hand = hand;
		m_Name = name;
		m_Line = line;
		m_Pos = pos;
	}
}

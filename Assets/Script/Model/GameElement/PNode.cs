using System.Collections.Generic;

internal class PNode
{
	private int m_G;

	private int m_H;

	private int m_X;

	private int m_Y;

	private PNode m_Parent;

	public Define.Point Point => new Define.Point(m_X, m_Y);

	public List<Define.Point> PointList
	{
		get
		{
			List<Define.Point> list = new List<Define.Point>();
			list.Add(Point);
			for (PNode parent = m_Parent; parent != null; parent = parent.Parent)
			{
				list.Add(parent.Point);
			}
			list.Reverse();
			return list;
		}
	}

	private PNode Parent => m_Parent;

	public int F => m_G + m_H;

	public int G => m_G;

	public int H => m_H;

	public int X => m_X;

	public int Y => m_Y;

	public PNode(int x, int y, int g, int h, PNode parent = null)
	{
		m_G = g;
		m_H = h;
		m_X = x;
		m_Y = y;
		m_Parent = parent;
	}
}

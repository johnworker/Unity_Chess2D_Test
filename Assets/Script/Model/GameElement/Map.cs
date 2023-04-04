public class Map
{
	private int m_Width;

	private int m_Height;

	private byte[] m_Data;

	public int Width => m_Width;

	public int Height => m_Height;

	public byte this[int x, int y] => m_Data[y * m_Width + x];

	public Map(int width, int height, byte[] data)
	{
		m_Width = width;
		m_Height = height;
		m_Data = data;
	}
}

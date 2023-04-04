public class Success
{
	private string m_Name = string.Empty;

	private string m_Describe = string.Empty;

	private int m_Target;

	private int m_Schedule;

	public string Name => m_Name;

	public string Describe => m_Describe;

	public int Target => m_Target;

	public int Schedule
	{
		get
		{
			return m_Schedule;
		}
		set
		{
			m_Schedule = value;
		}
	}

	public Success(string name, string describe, int target, int schedule = 0)
	{
		m_Name = name;
		m_Describe = describe;
		m_Target = target;
		m_Schedule = schedule;
	}
}

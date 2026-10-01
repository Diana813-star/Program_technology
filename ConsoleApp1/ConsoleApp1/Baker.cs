namespace ConsoleApp1;
/// <summary>
/// 
/// </summary>
public class Baker
{
    /// <summary>
    /// 
    /// </summary>
    public int Id { get; }
    public string FullName { get; private set; }
    public int Experience { get; private set; }
    public string Shift { get; private set; } 
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <param name="fullName"></param>
    /// <param name="experience"></param>
    /// <param name="shift"></param>
    public Baker(int id, string fullName, int experience, string shift) 
    {
        Id = id;
        FullName = fullName;
        Experience = experience;
        Shift = shift;
    }
    /// <summary>
    /// 
    /// </summary>
    public bool IsExperienced => Experience > 3;

    public string GetInfo()
    {
        return $"{FullName} ({Experience} лет опыта)";
    }
}

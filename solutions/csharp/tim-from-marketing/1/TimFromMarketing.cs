static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        if (department == null)
        {
            if (id == null)
            {
                return $"{name} - OWNER";
            }
            return $"[{id}] - {name} - OWNER";
        }
        
        string departmentUp = department.ToUpper();

        if (id == null)
        {
            return $"{name} - {departmentUp}";
        }
        
        return $"[{id}] - {name} - {departmentUp}";
    }
}

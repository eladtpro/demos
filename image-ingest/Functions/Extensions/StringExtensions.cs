namespace ImageIngest.Functions.Extensions;
public static class StringExtensions
{
    public static string BatchId(this string name)
    {
        return name.Split('_', 1, System.StringSplitOptions.RemoveEmptyEntries).FirstOrDefault();
    }

    public static string Sanitize(this string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("'name' string argument is null or empty", "name");
        //string illegal = "\"M\"\\a/ry/ h**ad:>> a\\/:*?\"| li*tt|le|| la\"mb.?";
        //string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
        //Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
        //illegal = r.Replace(illegal, "");

        return string.Concat(name.Split(Path.GetInvalidFileNameChars()));
    }
}
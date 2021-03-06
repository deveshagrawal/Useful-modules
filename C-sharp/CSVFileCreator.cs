//Converts any DTO to csv
private IEnumerable<string> ToCsv<T>(string separator, IEnumerable<T> objectlist)
{
    FieldInfo[] fields = typeof(T).GetFields();
    PropertyInfo[] properties = typeof(T).GetProperties();
    yield return String.Join(separator, fields.Select(f => f.Name).Union(properties.Select(p => p.Name)).ToArray());
    foreach (var o in objectlist)
    {
        yield return string.Join(separator, (properties.Select(p => (p.GetValue(o, null) ?? "").ToString())).ToArray());
    }
}

//Creating a csv file using stream of text
using (TextWriter tw = File.CreateText("filepath" + "filename"))
{
    foreach (var line in ToCsv(",", data))
    {
        tw.WriteLine(line);
    }
}

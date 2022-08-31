namespace ImageIngest.Functions.Extensions;
public static class DictionaryExtensions
{
    public static void RemoveAll<TKey, TValue>(this IDictionary<TKey, TValue> dic,
        Func<TKey, TValue, bool> predicate)
    {
        var keys = dic.Keys.Where(k => predicate(k, dic[k])).ToList();
        foreach (var key in keys)
            dic.Remove(key);
    }

    public static void UpdateAll<TKey, TValue>(this IDictionary<TKey, TValue> dic,
        Func<TKey, TValue, bool> predicate, Action<TValue> update)
    {
        var keys = dic.Keys.Where(k => predicate(k, dic[k])).ToList();
        foreach (var key in keys)
            update(dic[key]);
    }
}

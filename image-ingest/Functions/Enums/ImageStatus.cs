namespace ImageIngest.Functions.Enums;

public enum ImageStatus
{
    New = 0,
    Pending = 1,
    Batched = 2,
    Marked = 4,
    Zipped = 8,
    Deleted = 16,
    Error = -1,
    Completed = 1024
}

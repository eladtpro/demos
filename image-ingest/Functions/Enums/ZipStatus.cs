namespace ImageIngest.Functions.Enums;
public enum ZipStatus
{
    New = 0,
    Zipping = 1,
    Storing = 2,
    Stored = 4,
    Published = 8,
    Error = -1,
    Completed = 1024
}

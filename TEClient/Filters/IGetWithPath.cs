using System;
using TEClient.Interfaces;

namespace TEClient.Methods.FederalReserve;

internal interface IGetWithPath
{ }

internal class PathString: IGetWithPath
{
    public PathString(string path)
    {
        if (path.FirstOrDefault() != '/')
        {
            path = $"/{path}";
        }

        Value = path;
    }

    public string Value { get; init; }

    public static implicit operator PathString(string path)
    {
        return new PathString(path);
    }

    public static implicit operator PathString(string[] paths)
    {
        var path = string.Join("/", paths);
        return new PathString(path);
    }

}
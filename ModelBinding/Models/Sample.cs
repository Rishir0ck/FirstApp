using System;

namespace ModelBinding.Models;

public class CustomObject
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Location { get; set; }
}

public class ComplexBodyModel
{
    public string? Data { get; set; }
}

public class MergedModel
{
    public string? Header { get; set; }
    public string? Query { get; set; }
    public string? BodyData { get; set; }
}

public class CustomTupleModel
{
    public int Item1 { get; set; }
    public string? Item2 { get; set; }
}

public class LargeDataModel
{
    public List<string>? LargeDataList { get; set; }
}
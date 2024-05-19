#r "nuget: KiDev.Baikal"
Solution(__SOURCE_DIRECTORY__)
    |> AddProject(CS() |> OutputType Exe)
    |> run
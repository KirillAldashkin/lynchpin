using System.Net.Http.Json;

const string Url = "https://ak.hypergryph.com/lynchpin/api/meta";
var path = Environment.ExpandEnvironmentVariables("%GITHUB_WORKSPACE%/data.tsv");
var data = await new HttpClient().GetFromJsonAsync<Response>(Url);
File.AppendAllText(path, $"{DateTime.UtcNow}\t{data.code}\t{data.data.progress}\t\"{data.msg}\"\n");

record Data(long progress);
record Response(long code, Data data, string msg);
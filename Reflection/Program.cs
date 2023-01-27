using System.Reflection;
using System.IO;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json;



DirectoryInfo directory = new DirectoryInfo(Directory.GetCurrentDirectory());

string config = File.ReadAllText(directory.GetFiles().
                               Where(x=>x.Name.Contains("config")).First().FullName);

dynamic configJson= JsonConvert.DeserializeObject(config);
Type t=Assembly.GetExecutingAssembly().GetTypes().
           Where(x=>x.Name==configJson.ClassName.ToString() && x.GetInterface("IReflection")!=null).First();

ConstructorInfo constructor= t?.GetConstructor( new Type[] {typeof(string)});
object o = constructor?.Invoke(new object[] {"Demo program"});

MethodInfo method= t?.GetMethod("start", new Type[] {});

method?.Invoke(o, new object[] {});

